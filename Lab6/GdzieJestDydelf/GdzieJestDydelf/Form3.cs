using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GdzieJestDydelf
{
    public partial class Form3: Form
    {
        private Form1 parent;
        private Button[,] plansza;
        private const int ROZMIAR_POLA = 50; // rozmiar pojedynczego pola w pikselach
        private Label labelCzas;
        private Label labelDydelfy;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timerKrokodyl;
        private System.Windows.Forms.Timer timerSzop;
        private int pozostalyCzas;
        private bool[,] odkrytePola; // true - odkryte, false - zakryte
        private int[,] zwierzeta; // 0 - puste, 1 - dydelf, 2 - krokodyl, 3 - szop
        private Random random = new Random();
        private int odkryteDydelfy;
        private Button aktywnyKrokodyl; // Pole z aktywnym krokodylem
        private Button aktywnySzop; // Pole z aktywnym szopem
        private const int CZAS_KROKODYL = 2; // Czas w sekundach na zakrycie krokodyla
        private const int CZAS_SZOP = 2; // Czas w sekundach na działanie szopa

        public Form3(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
            odkryteDydelfy = 0;
            InicjalizujTimer();
            GenerujPlansze();
            RozmiescZwierzeta();
        }

        private void InicjalizujTimer()
        {
            // Inicjalizacja labela z czasem
            labelCzas = new Label();
            labelCzas.AutoSize = true;
            labelCzas.Font = new Font("Arial", 16, FontStyle.Bold);
            labelCzas.Location = new Point(20, (parent.OsY * ROZMIAR_POLA) + (2 * 20));
            this.Controls.Add(labelCzas);

            // Inicjalizacja labela z dydelfami
            labelDydelfy = new Label();
            labelDydelfy.AutoSize = true;
            labelDydelfy.Font = new Font("Arial", 16, FontStyle.Bold);
            labelDydelfy.Location = new Point(20, (parent.OsY * ROZMIAR_POLA) + (4 * 20));
            this.Controls.Add(labelDydelfy);

            // Inicjalizacja timera gry
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 sekunda
            timer.Tick += Timer_Tick;
            
            // Inicjalizacja timera krokodyla
            timerKrokodyl = new System.Windows.Forms.Timer();
            timerKrokodyl.Interval = CZAS_KROKODYL * 1000; // 2 sekundy
            timerKrokodyl.Tick += TimerKrokodyl_Tick;
            
            // Inicjalizacja timera szopa
            timerSzop = new System.Windows.Forms.Timer();
            timerSzop.Interval = CZAS_SZOP * 1000; // 2 sekundy
            timerSzop.Tick += TimerSzop_Tick;
            
            // Ustawienie początkowego czasu
            pozostalyCzas = parent.Czas;
            AktualizujWyswietlanieCzasu();
            AktualizujWyswietlanieDydelfow();
            
            // Uruchomienie timera gry
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            pozostalyCzas--;
            AktualizujWyswietlanieCzasu();

            if (pozostalyCzas <= 0)
            {
                timer.Stop();
                MessageBox.Show("KONIEC CZASU, PRZEGRAŁEŚ :((((");
                this.Close();
                parent.Show();
            }
        }

        private void TimerKrokodyl_Tick(object sender, EventArgs e)
        {
            timerKrokodyl.Stop();
            timer.Stop();
            MessageBox.Show("TRAFIŁEŚ NA KROKODYLA. KONIEC GRY :(");
            this.Close();
            parent.Show();
        }

        private void TimerSzop_Tick(object sender, EventArgs e)
        {
            timerSzop.Stop();
            if (aktywnySzop != null)
            {
                Point szopCoords = (Point)aktywnySzop.Tag;
                // Zakryj szopa i jego sąsiadów
                ZakryjPoleIAktualizujLiczniki(szopCoords.X, szopCoords.Y);
                foreach (var sasiad in ZnajdzSasiadow(szopCoords.X, szopCoords.Y))
                {
                    ZakryjPoleIAktualizujLiczniki(sasiad.X, sasiad.Y);
                }
                aktywnySzop = null;
            }
        }

        private List<Point> ZnajdzSasiadow(int x, int y)
        {
            List<Point> sasiedzi = new List<Point>();
            // Sprawdź wszystkie 8 kierunków
            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    if (dx == 0 && dy == 0) continue; // Pomijamy samo pole
                    
                    int nowyX = x + dx;
                    int nowyY = y + dy;
                    
                    // Sprawdź czy współrzędne są w zakresie planszy
                    if (nowyX >= 0 && nowyX < parent.OsX && nowyY >= 0 && nowyY < parent.OsY)
                    {
                        sasiedzi.Add(new Point(nowyX, nowyY));
                    }
                }
            }
            return sasiedzi;
        }

        private void ZakryjPoleIAktualizujLiczniki(int x, int y)
        {
            if (odkrytePola[x, y])
            {
                odkrytePola[x, y] = false;
                plansza[x, y].BackColor = Color.Gray;
                plansza[x, y].BackgroundImage = null;
                plansza[x, y].Enabled = true;

                // Aktualizuj licznik dydelfów jeśli zakrywamy dydelfa
                if (zwierzeta[x, y] == 1)
                {
                    odkryteDydelfy--;
                    AktualizujWyswietlanieDydelfow();
                }
            }
        }

        private void AktualizujWyswietlanieCzasu()
        {
            labelCzas.Text = $"Pozostały czas: {pozostalyCzas} sekund";
        }

        private void AktualizujWyswietlanieDydelfow()
        {
            labelDydelfy.Text = $"Nieodkryte dydelfy: {parent.Dydelfy - odkryteDydelfy}";
        }

        private void RozmiescZwierzeta()
        {
            // Inicjalizacja tablicy zwierząt
            zwierzeta = new int[parent.OsX, parent.OsY];
            
            // Lista wszystkich dostępnych pól
            List<Point> dostepnePola = new List<Point>();
            for (int x = 0; x < parent.OsX; x++)
                for (int y = 0; y < parent.OsY; y++)
                    dostepnePola.Add(new Point(x, y));

            // Rozmieszczenie dydelfów
            for (int i = 0; i < parent.Dydelfy; i++)
            {
                if (dostepnePola.Count > 0)
                {
                    int index = random.Next(dostepnePola.Count);
                    Point pole = dostepnePola[index];
                    zwierzeta[pole.X, pole.Y] = 1;
                    dostepnePola.RemoveAt(index);
                }
            }

            // Rozmieszczenie krokodyli
            for (int i = 0; i < parent.Krokodyle; i++)
            {
                if (dostepnePola.Count > 0)
                {
                    int index = random.Next(dostepnePola.Count);
                    Point pole = dostepnePola[index];
                    zwierzeta[pole.X, pole.Y] = 2;
                    dostepnePola.RemoveAt(index);
                }
            }

            // Rozmieszczenie szopów
            for (int i = 0; i < parent.Szopy; i++)
            {
                if (dostepnePola.Count > 0)
                {
                    int index = random.Next(dostepnePola.Count);
                    Point pole = dostepnePola[index];
                    zwierzeta[pole.X, pole.Y] = 3;
                    dostepnePola.RemoveAt(index);
                }
            }
        }

        private void GenerujPlansze()
        {
            // Inicjalizacja tablicy przycisków i stanów pól
            plansza = new Button[parent.OsX, parent.OsY];
            odkrytePola = new bool[parent.OsX, parent.OsY];

            // Ustawienie rozmiaru formularza
            const int MARGINES = 20;
            const int DODATKOWA_PRZESTRZEN = 150; // Zwiększony margines od dołu
            this.Width = (parent.OsX * ROZMIAR_POLA) + (2 * MARGINES) + MARGINES; // Dodatkowy MARGINES na prawą stronę
            this.Height = (parent.OsY * ROZMIAR_POLA) + (2 * MARGINES) + DODATKOWA_PRZESTRZEN;

            // Generowanie przycisków
            for (int x = 0; x < parent.OsX; x++)
            {
                for (int y = 0; y < parent.OsY; y++)
                {
                    Button pole = new Button();
                    pole.Location = new Point(x * ROZMIAR_POLA + MARGINES, y * ROZMIAR_POLA + MARGINES);
                    pole.Size = new Size(ROZMIAR_POLA, ROZMIAR_POLA);
                    pole.Tag = new Point(x, y); // zapisujemy współrzędne pola
                    pole.Click += Pole_Click;
                    pole.FlatStyle = FlatStyle.Flat; // Płaski styl przycisku
                    pole.BackColor = Color.Gray; // Domyślny kolor - szary (zakryte pole)
                    
                    plansza[x, y] = pole;
                    odkrytePola[x, y] = false; // Początkowo wszystkie pola są zakryte
                    this.Controls.Add(pole);
                }
            }
        }

        private void Pole_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Point coordinates = (Point)clickedButton.Tag;
            
            // Jeśli pole jest zablokowane (aktywny szop), ignoruj kliknięcie
            if (!clickedButton.Enabled)
                return;
            
            // Przełącz stan pola (odkryte -> zakryte lub zakryte -> odkryte)
            odkrytePola[coordinates.X, coordinates.Y] = !odkrytePola[coordinates.X, coordinates.Y];
            
            // Ustaw odpowiedni kolor i obraz w zależności od stanu
            if (odkrytePola[coordinates.X, coordinates.Y])
            {
                clickedButton.BackColor = Color.White;
                // Ustaw odpowiedni obraz w zależności od zwierzęcia
                switch (zwierzeta[coordinates.X, coordinates.Y])
                {
                    case 1: // Dydelf
                        clickedButton.BackgroundImage = Image.FromFile("dydelf.png");
                        clickedButton.BackgroundImageLayout = ImageLayout.Stretch;
                        odkryteDydelfy++;
                        AktualizujWyswietlanieDydelfow();
                        
                        // Sprawdź warunek wygranej
                        if (odkryteDydelfy == parent.Dydelfy)
                        {
                            timer.Stop();
                            MessageBox.Show("BRAWO, UDAŁO CI SIĘ WYGRAĆ!!! GRATULACJE");
                            this.Close();
                            parent.Show();
                        }
                        break;
                    case 2: // Krokodyl
                        clickedButton.BackgroundImage = Image.FromFile("krokodyl.png");
                        clickedButton.BackgroundImageLayout = ImageLayout.Stretch;
                        aktywnyKrokodyl = clickedButton;
                        timerKrokodyl.Start();
                        break;
                    case 3: // Szop
                        clickedButton.BackgroundImage = Image.FromFile("szop.png");
                        clickedButton.BackgroundImageLayout = ImageLayout.Stretch;
                        aktywnySzop = clickedButton;
                        clickedButton.Enabled = false; // Zablokuj przycisk
                        timerSzop.Start();
                        break;
                    default: // Puste pole
                        clickedButton.BackgroundImage = null;
                        break;
                }
            }
            else
            {
                clickedButton.BackColor = Color.Gray;
                clickedButton.BackgroundImage = null;
                // Jeśli zakrywamy dydelfa, zmniejszamy licznik
                if (zwierzeta[coordinates.X, coordinates.Y] == 1)
                {
                    odkryteDydelfy--;
                    AktualizujWyswietlanieDydelfow();
                }
                // Jeśli zakrywamy krokodyla, zatrzymujemy jego timer
                else if (zwierzeta[coordinates.X, coordinates.Y] == 2)
                {
                    timerKrokodyl.Stop();
                    aktywnyKrokodyl = null;
                }
            }
        }
    }
}
