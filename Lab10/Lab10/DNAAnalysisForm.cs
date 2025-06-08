using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text;

namespace Lab10
{
    public partial class DNAAnalysisForm : Form
    {
        private List<DNASequence> sequences;

        public DNAAnalysisForm(string filePath)
        {
            InitializeComponent();
            this.buttonExportCSV.Text = "Eksport CSV";
            this.buttonExportJSON.Text = "Eksport JSON";
            sequences = new List<DNASequence>();
            LoadFASTAFile(filePath);
        }

        private void LoadFASTAFile(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                string currentHeader = null;
                string currentSequence = "";

                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i].Trim();
                    
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    if (line.StartsWith(">"))
                    {
                        // Jeśli mamy poprzednią sekwencję, zapisz ją
                        if (currentHeader != null)
                        {
                            sequences.Add(new DNASequence(currentHeader, currentSequence));
                            currentSequence = "";
                        }
                        currentHeader = line.Substring(1); // Usuń '>' z początku
                    }
                    else
                    {
                        // Walidacja sekwencji - sprawdź czy zawiera tylko dozwolone znaki
                        if (!line.All(c => "ATGC".Contains(char.ToUpper(c))))
                        {
                            throw new Exception($"Nieprawidłowe znaki w sekwencji DNA w linii {i + 1}");
                        }
                        currentSequence += line;
                    }
                }

                // Dodaj ostatnią sekwencję
                if (currentHeader != null)
                {
                    sequences.Add(new DNASequence(currentHeader, currentSequence));
                }

                if (sequences.Count == 0)
                {
                    throw new Exception("Nie znaleziono żadnych sekwencji w pliku");
                }

                // Wyświetl sekwencje w ListView
                DisplaySequences();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas wczytywania pliku: {ex.Message}", "Błąd", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void DisplaySequences()
        {
            listViewSequences.Items.Clear();
            foreach (var sequence in sequences)
            {
                var item = new ListViewItem(sequence.Header);
                item.SubItems.Add(sequence.Length.ToString());
                listViewSequences.Items.Add(item);
            }
        }

        private void listViewSequences_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSequences.SelectedItems.Count > 0)
            {
                int selectedIndex = listViewSequences.SelectedIndices[0];
                var sequence = sequences[selectedIndex];
                
                labelGCContent.Text = $"Zawartość GC: {sequence.GCContent:F2}%";
                labelCodonCount.Text = $"Liczba kodonów: {sequence.CodonCount}";
                
                var baseCounts = sequence.BaseCounts;
                labelBaseCounts.Text = $"Liczba zasad: A={baseCounts['A']}, T={baseCounts['T']}, G={baseCounts['G']}, C={baseCounts['C']}";
            }
        }

        private void DNAAnalysisForm_Load(object sender, EventArgs e)
        {
            UpdatePlot();
        }

        private void UpdatePlot()
        {
            formsPlot1.Plot.Clear();
            
            var lengths = sequences.Select(s => (double)s.Length).ToArray();
            var positions = Enumerable.Range(0, sequences.Count).Select(i => (double)i).ToArray();
            var labels = sequences.Select(s => s.Header).ToArray();

            var bar = formsPlot1.Plot.AddBar(lengths);
            bar.ShowValuesAboveBars = true;
            
            formsPlot1.Plot.XTicks(positions, labels);
            formsPlot1.Plot.XLabel("Sekwencja");
            formsPlot1.Plot.YLabel("Długość");
            formsPlot1.Plot.Title("Długości sekwencji DNA");
            
            formsPlot1.Refresh();
        }

        private void buttonExportCSV_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Pliki CSV (*.csv)|*.csv";
                saveFileDialog.Title = "Zapisz wyniki jako CSV";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var csv = new StringBuilder();
                    csv.AppendLine("Nazwa,Długość,Zawartość GC,Liczba kodonów,A,T,G,C");

                    foreach (var sequence in sequences)
                    {
                        var baseCounts = sequence.BaseCounts;
                        csv.AppendLine($"{sequence.Header},{sequence.Length},{sequence.GCContent:F2},{sequence.CodonCount}," +
                            $"{baseCounts['A']},{baseCounts['T']},{baseCounts['G']},{baseCounts['C']}");
                    }

                    File.WriteAllText(saveFileDialog.FileName, csv.ToString());
                    MessageBox.Show("Dane zostały wyeksportowane do pliku CSV.", "Sukces", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonExportJSON_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Pliki JSON (*.json)|*.json";
                saveFileDialog.Title = "Zapisz wyniki jako JSON";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var exportData = sequences.Select(s => new
                    {
                        s.Header,
                        s.Length,
                        GCContent = s.GCContent,
                        s.CodonCount,
                        BaseCounts = s.BaseCounts
                    });

                    string json = JsonSerializer.Serialize(exportData, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(saveFileDialog.FileName, json);
                    MessageBox.Show("Dane zostały wyeksportowane do pliku JSON.", "Sukces", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }

    public class DNASequence
    {
        public string Header { get; private set; }
        public string Sequence { get; private set; }
        public int Length => Sequence.Length;
        public double GCContent => CalculateGCContent();
        public int CodonCount => Length / 3;
        public Dictionary<char, int> BaseCounts => CountBases();

        public DNASequence(string header, string sequence)
        {
            Header = header;
            Sequence = sequence.ToUpper();
        }

        private double CalculateGCContent()
        {
            int gcCount = Sequence.Count(c => c == 'G' || c == 'C');
            return (double)gcCount / Length * 100;
        }

        private Dictionary<char, int> CountBases()
        {
            return new Dictionary<char, int>
            {
                ['A'] = Sequence.Count(c => c == 'A'),
                ['T'] = Sequence.Count(c => c == 'T'),
                ['G'] = Sequence.Count(c => c == 'G'),
                ['C'] = Sequence.Count(c => c == 'C')
            };
        }
    }
} 