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

        private Bitmap FilterOnlyGreen(Bitmap img)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color pixel = img.GetPixel(x, y);
                    if (pixel.G > pixel.R && pixel.G > pixel.B)
                    {
                        bmp.SetPixel(x, y, Color.FromArgb(pixel.R, pixel.G, pixel.B));
                    }
                    else
                    {
                        bmp.SetPixel(x, y, Color.Black);
                    }
                }
            }

            return bmp;
        }

        private void button_OnlyGreen_Click(object sender, EventArgs e)
        {
            if (pictureBox1 == null)
                return;

            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap onlyGreen = FilterOnlyGreen(bmp);
            pictureBox1.Image = onlyGreen;
        }
    }
}
