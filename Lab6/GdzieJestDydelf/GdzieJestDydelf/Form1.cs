namespace GdzieJestDydelf
{
    public partial class Form1 : Form
    {
        // Właściwości do przechowywania ustawień
        public int OsX { get; set; } = 6;
        public int OsY { get; set; } = 6;
        public int Dydelfy { get; set; } = 3;
        public int Krokodyle { get; set; } = 1;
        public int Szopy { get; set; } = 5;
        public int Czas { get; set; } = 35;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
            this.Hide();
        }

        private void button_ustawienia_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            this.Hide();
        }

        private void button_koniec_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Czy na pewno chcesz nas opuścić?",
                "Potwierdzenie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
