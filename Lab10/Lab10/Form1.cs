namespace Lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_wczytaj_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Pliki FASTA (*.fasta)|*.fasta|Wszystkie pliki (*.*)|*.*";
                openFileDialog.Title = "Wybierz plik FASTA";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var analysisForm = new DNAAnalysisForm(openFileDialog.FileName);
                    analysisForm.ShowDialog();
                }
            }
        }
    }
}
