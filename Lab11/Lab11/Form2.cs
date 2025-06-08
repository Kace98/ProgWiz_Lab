using System;
using System.Windows.Forms;

namespace Lab11
{
    public partial class Form2 : Form
    {
        public Próbka NowaPróbka { get; private set; }
        private bool trybEdycji;

        public Form2()
        {
            InitializeComponent();
            comboBox_typ.Items.AddRange(new string[] { "DNA", "RNA", "Białko", "Inny" });
            comboBox_typ.SelectedIndex = 0;
            dateTimePicker_data.Value = DateTime.Now;
            trybEdycji = false;
        }

        public Form2(Próbka próbka) : this()
        {
            trybEdycji = true;
            NowaPróbka = próbka;
            textBox_nazwa.Text = próbka.Nazwa;
            comboBox_typ.SelectedItem = próbka.Typ;
            dateTimePicker_data.Value = próbka.DataPobrania;
            textBox_opis.Text = próbka.Opis;
            this.Text = "Edytuj próbkę";
        }

        private void button_zapisz_Click(object sender, EventArgs e)
        {
            if (NowaPróbka == null)
            {
                NowaPróbka = new Próbka();
            }

            NowaPróbka.Nazwa = textBox_nazwa.Text;
            NowaPróbka.Typ = comboBox_typ.SelectedItem.ToString();
            NowaPróbka.DataPobrania = dateTimePicker_data.Value;
            NowaPróbka.Opis = textBox_opis.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void button_anuluj_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
} 