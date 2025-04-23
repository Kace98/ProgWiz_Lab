using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Collections.Generic;
using System.Linq;

namespace AvaloniaApplication.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void AnalyzeButton_Click(object sender, RoutedEventArgs e)
    {
        string sequence = DnaSequenceInput.Text?.ToUpper() ?? "";
        
        // Sprawdzenie czy sekwencja zawiera tylko dozwolone znaki
        if (!sequence.All(c => "ACGT".Contains(c)))
        {
            ResultsList.ItemsSource = new List<string> { "Błąd: Sekwencja może zawierać tylko znaki A, C, G, T" };
            return;
        }

        // Zliczanie sekwencji 4-nukleotydowych
        var sequences = new Dictionary<string, int>();
        for (int i = 0; i <= sequence.Length - 4; i++)
        {
            string subsequence = sequence.Substring(i, 4);
            if (sequences.ContainsKey(subsequence))
                sequences[subsequence]++;
            else
                sequences[subsequence] = 1;
        }

        // Sortowanie wyników
        var sortedResults = sequences.OrderByDescending(x => x.Value)
                                   .Select(x => $"{x.Key}: {x.Value}")
                                   .ToList();

        ResultsList.ItemsSource = sortedResults;
    }
}
