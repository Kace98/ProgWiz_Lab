namespace GdzieJestDydelf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {

        }

        private void button_ustawienia_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            this.Hide();
        }

        private void button_koniec_Click(object sender, EventArgs e)
        {
            
        }
    }
}
