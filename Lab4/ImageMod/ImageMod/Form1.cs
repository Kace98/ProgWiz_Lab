using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageMod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Ustawienie trybu skalowania obrazu
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void button_rotate_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
                return;

            Image img = pictureBox1.Image;
            Bitmap bmp = new Bitmap(img);

            if (radioButton_90.Checked)
                bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            else if (radioButton_180.Checked)
                bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);
            else if (radioButton_270.Checked)
                bmp.RotateFlip(RotateFlipType.Rotate270FlipNone);

            pictureBox1.Image = bmp;

        }
    }
}
