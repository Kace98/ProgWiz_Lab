using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using QRCoder;

namespace Lab11
{
    public partial class Form3 : Form
    {
        private Próbka próbka;
        private Bitmap qrCodeImage;

        public Form3(Próbka próbka)
        {
            InitializeComponent();
            this.próbka = próbka;
            GenerujKodQR();
        }

        private void GenerujKodQR()
        {
            // Tworzymy tekst do zakodowania w QR
            string qrText = $"ID: {próbka.ID}\nNazwa: {próbka.Nazwa}\nTyp: {próbka.Typ}\nData: {próbka.DataPobrania:dd.MM.yyyy}\nOpis: {próbka.Opis}";

            // Generujemy kod QR
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            qrCodeImage = qrCode.GetGraphic(20);

            // Wyświetlamy kod QR
            pictureBox1.Image = qrCodeImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button_eksportuj_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Pliki PNG|*.png";
                saveDialog.Title = "Zapisz kod QR";
                saveDialog.FileName = $"QR_{próbka.Nazwa}_{DateTime.Now:yyyyMMdd}";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    qrCodeImage.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    MessageBox.Show("Kod QR został zapisany.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button_drukuj_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();

            printDocument.PrintPage += (s, ev) =>
            {
                // Obliczamy rozmiar obrazu na stronie
                float scale = Math.Min(
                    ev.MarginBounds.Width / (float)qrCodeImage.Width,
                    ev.MarginBounds.Height / (float)qrCodeImage.Height
                );

                int width = (int)(qrCodeImage.Width * scale);
                int height = (int)(qrCodeImage.Height * scale);

                // Wyśrodkowujemy obraz
                int x = ev.MarginBounds.X + (ev.MarginBounds.Width - width) / 2;
                int y = ev.MarginBounds.Y + (ev.MarginBounds.Height - height) / 2;

                // Dodajemy tekst pod kodem QR
                string text = $"Próbka: {próbka.Nazwa}\nTyp: {próbka.Typ}";
                Font font = new Font("Arial", 10);
                SizeF textSize = ev.Graphics.MeasureString(text, font);

                // Rysujemy obraz i tekst
                ev.Graphics.DrawImage(qrCodeImage, x, y, width, height);
                ev.Graphics.DrawString(text, font, Brushes.Black, 
                    x + (width - textSize.Width) / 2, 
                    y + height + 10);
            };

            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
    }
} 