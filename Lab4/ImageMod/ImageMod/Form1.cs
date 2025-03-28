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

        private Bitmap InvertColors(Bitmap bmp)
        {
            Bitmap invertedBmp = new Bitmap(bmp.Width, bmp.Height);

            for (int x=0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color pixel = bmp.GetPixel(x, y);
                    Color invertedPixel = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    invertedBmp.SetPixel(x, y, invertedPixel);
                }
            }

            return invertedBmp;
        }

        private void button_invertColors_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
                return;

            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap negativeBmp = InvertColors(bmp);
            pictureBox1.Image = negativeBmp;
        }

        private void button_UpsideDown_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
                return;

            Image img = pictureBox1.Image;
            Bitmap bmp = new Bitmap(img);

            bmp.RotateFlip(RotateFlipType.RotateNoneFlipY);

            pictureBox1.Image = bmp;
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
