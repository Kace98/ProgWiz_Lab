namespace KalkulatorCen
{
    public partial class Form1 : Form
    {
        // Zmienne przechowujące ceny
        public decimal cenaKomputera = 0; // Suma cen procesora i dysku
        public decimal cenaMonitora = 0;

        public Form1()
        {
            InitializeComponent();
            AktualizujSumeCen();
        }

        public void AktualizujSumeCen()
        {
            decimal suma = cenaKomputera + cenaMonitora;
            label_SumaCen.Text = $"{suma}";
        }

        private void button_komp_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            this.Hide();
        }

        private void button_Moni_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
            this.Hide();
        }

        private void label_SumaCen_Click(object sender, EventArgs e)
        {
            // Pusta metoda wymagana przez projektant formularza
        }
    }
}
