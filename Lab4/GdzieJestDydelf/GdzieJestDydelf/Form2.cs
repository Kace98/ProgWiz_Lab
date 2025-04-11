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
    public partial class Form2 : Form
    {

        //Określenie liczby dostępnych pól
        private int dostepnePola;  

        private Form1 parent;
        public Form2(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
            dostepnePola = numericUpDown_OsX * numericUpDown_OsY - numericUpDown_Dedelfy - numericUpDown_Krokodyle - numericUpDown_Szopy;

        }
        private void numericUpDown_OsX_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_OsY_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_Dedelfy_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_Krokodyle_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_Szopy_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Czas_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_OK_Click(object sender, EventArgs e)
        {

        }

        private void button_Anuluj_Click(object sender, EventArgs e)
        {

        }
    }
}
