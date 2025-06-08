using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.IO;
using System.Linq;

namespace Lab12
{
    public class SesjaDocument
    {
        private readonly Sesja sesja;

        public SesjaDocument(Sesja sesja)
        {
            this.sesja = sesja;
        }

        public void Generate(string outputPath)
        {
            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.DefaultTextStyle(x => x.FontSize(11));

                    page.Header().Element(ComposeHeader);
                    page.Content().Element(ComposeContent);
                    page.Footer().Element(ComposeFooter);
                });
            });

            document.GeneratePdf(outputPath);
        }

        private void ComposeHeader(IContainer container)
        {
            container.Row(row =>
            {
                row.RelativeItem().Column(column =>
                {
                    column.Item().Text(sesja.Tytul).FontSize(20).Bold();
                    column.Item().Text($"Data utworzenia: {sesja.DataUtworzenia:dd.MM.yyyy HH:mm}").FontSize(12);
                });
            });
        }

        private void ComposeContent(IContainer container)
        {
            container.PaddingVertical(20).Column(column =>
            {
                foreach (var wpis in sesja.Wpisy)
                {
                    column.Item().Element(container => ComposeWpis(container, wpis));
                    column.Item().PaddingVertical(10).LineHorizontal(1).LineColor(Colors.Grey.Lighten2);
                }
            });
        }

        private void ComposeWpis(IContainer container, Wpis wpis)
        {
            container.Column(column =>
            {
                // Nagłówek wpisu
                column.Item().Background(Colors.Grey.Lighten3).Padding(10).Column(wpisColumn =>
                {
                    wpisColumn.Item().Text(wpis.Nazwa).FontSize(14).Bold();
                    wpisColumn.Item().Text($"Data dodania: {wpis.DataDodania:dd.MM.yyyy HH:mm}").FontSize(10);
                    wpisColumn.Item().Text($"Typ: {wpis.Typ}").FontSize(10);
                    if (!string.IsNullOrEmpty(wpis.Opis))
                    {
                        wpisColumn.Item().Text($"Opis: {wpis.Opis}").FontSize(10);
                    }
                });

                // Zawartość wpisu
                column.Item().Padding(10).Element(content =>
                {
                    if (wpis.Typ == "Tekstowy")
                    {
                        content.Text(wpis.Tresc).FontSize(11);
                    }
                    else if (wpis.Typ == "Załącznik")
                    {
                        string extension = Path.GetExtension(wpis.SciezkaPliku).ToLower();
                        if (extension == ".png")
                        {
                            if (File.Exists(wpis.SciezkaPliku))
                            {
                                content.Image(wpis.SciezkaPliku).FitArea();
                            }
                            else
                            {
                                content.Text("Nie znaleziono pliku obrazu").FontSize(11).FontColor(Colors.Red.Medium);
                            }
                        }
                        else if (extension == ".csv" || extension == ".fasta")
                        {
                            if (File.Exists(wpis.SciezkaPliku))
                            {
                                string fileContent = File.ReadAllText(wpis.SciezkaPliku);
                                content.Text(fileContent).FontSize(11).FontFamily(Fonts.Courier);
                            }
                            else
                            {
                                content.Text("Nie znaleziono pliku").FontSize(11).FontColor(Colors.Red.Medium);
                            }
                        }
                    }
                });
            });
        }

        private void ComposeFooter(IContainer container)
        {
            container.Row(row =>
            {
                row.RelativeItem().Text(text =>
                {
                    text.Span("Strona ").FontSize(10);
                    text.CurrentPageNumber().FontSize(10);
                    text.Span(" z ").FontSize(10);
                    text.TotalPages().FontSize(10);
                });
            });
        }
    }
} 