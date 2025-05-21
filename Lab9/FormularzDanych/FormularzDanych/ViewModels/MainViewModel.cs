using ReactiveUI;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System;

namespace FormularzDanych.ViewModels;

public class MainViewModel : ViewModelBase
{
    private string? _dataWypelnienia;
    private string? _numerAlbumu;
    private string? _nazwiskoImie;
    private string? _semestrRok;
    private string? _kierunekStopien;
    private string? _przedmiot;
    private string? _punkty;
    private string? _prowadzacy;
    private string? _uzasadnienie;
    private string? _dataPodpisStudenta;
    private string? _decyzja;
    private string? _komisja1;
    private string? _komisja2;
    private string? _komisja3;
    private string? _dataDecyzji;
    private string? _statusMessage;
    private bool _isLoading;

    public string? DataWypelnienia 
    { 
        get => _dataWypelnienia;
        set => this.RaiseAndSetIfChanged(ref _dataWypelnienia, value);
    }
    public string? NumerAlbumu 
    { 
        get => _numerAlbumu;
        set => this.RaiseAndSetIfChanged(ref _numerAlbumu, value);
    }
    public string? NazwiskoImie 
    { 
        get => _nazwiskoImie;
        set => this.RaiseAndSetIfChanged(ref _nazwiskoImie, value);
    }
    public string? SemestrRok 
    { 
        get => _semestrRok;
        set => this.RaiseAndSetIfChanged(ref _semestrRok, value);
    }
    public string? KierunekStopien 
    { 
        get => _kierunekStopien;
        set => this.RaiseAndSetIfChanged(ref _kierunekStopien, value);
    }
    public string? Przedmiot 
    { 
        get => _przedmiot;
        set => this.RaiseAndSetIfChanged(ref _przedmiot, value);
    }
    public string? Punkty 
    { 
        get => _punkty;
        set => this.RaiseAndSetIfChanged(ref _punkty, value);
    }
    public string? Prowadzacy 
    { 
        get => _prowadzacy;
        set => this.RaiseAndSetIfChanged(ref _prowadzacy, value);
    }
    public string? Uzasadnienie 
    { 
        get => _uzasadnienie;
        set => this.RaiseAndSetIfChanged(ref _uzasadnienie, value);
    }
    public string? DataPodpisStudenta 
    { 
        get => _dataPodpisStudenta;
        set => this.RaiseAndSetIfChanged(ref _dataPodpisStudenta, value);
    }
    public string? Decyzja 
    { 
        get => _decyzja;
        set => this.RaiseAndSetIfChanged(ref _decyzja, value);
    }
    public string? Komisja1 
    { 
        get => _komisja1;
        set => this.RaiseAndSetIfChanged(ref _komisja1, value);
    }
    public string? Komisja2 
    { 
        get => _komisja2;
        set => this.RaiseAndSetIfChanged(ref _komisja2, value);
    }
    public string? Komisja3 
    { 
        get => _komisja3;
        set => this.RaiseAndSetIfChanged(ref _komisja3, value);
    }
    public string? DataDecyzji 
    { 
        get => _dataDecyzji;
        set => this.RaiseAndSetIfChanged(ref _dataDecyzji, value);
    }
    public string? StatusMessage 
    { 
        get => _statusMessage;
        set => this.RaiseAndSetIfChanged(ref _statusMessage, value);
    }
    public bool IsLoading 
    { 
        get => _isLoading;
        set => this.RaiseAndSetIfChanged(ref _isLoading, value);
    }

    public ObservableCollection<Wniosek> Wnioski { get; } = new();

    private readonly DatabaseManager _db = new();

    public ICommand ZapiszCommand => ReactiveCommand.Create(Zapisz);
    public ICommand PokazWpisyCommand => ReactiveCommand.Create(PokazWpisy);
    public ICommand WyczyscFormularzCommand => ReactiveCommand.Create(WyczyscFormularz);

    private bool WalidujFormularz()
    {
        if (string.IsNullOrWhiteSpace(NumerAlbumu))
        {
            StatusMessage = "Numer albumu jest wymagany";
            return false;
        }
        if (string.IsNullOrWhiteSpace(NazwiskoImie))
        {
            StatusMessage = "Imię i nazwisko jest wymagane";
            return false;
        }
        if (string.IsNullOrWhiteSpace(Przedmiot))
        {
            StatusMessage = "Przedmiot jest wymagany";
            return false;
        }
        return true;
    }

    private void Zapisz()
    {
        if (!WalidujFormularz())
            return;

        try
        {
            IsLoading = true;
            var wniosek = new Wniosek
            {
                DataWypelnienia = DateTime.Now.ToString("dd.MM.yyyy"),
                NumerAlbumu = this.NumerAlbumu,
                NazwiskoImie = this.NazwiskoImie,
                SemestrRok = this.SemestrRok,
                KierunekStopien = this.KierunekStopien,
                Przedmiot = this.Przedmiot,
                Punkty = this.Punkty,
                Prowadzacy = this.Prowadzacy,
                Uzasadnienie = this.Uzasadnienie,
                DataPodpisStudenta = this.DataPodpisStudenta,
                Decyzja = this.Decyzja,
                Komisja1 = this.Komisja1,
                Komisja2 = this.Komisja2,
                Komisja3 = this.Komisja3,
                DataDecyzji = this.DataDecyzji
            };
            _db.WriteData(wniosek);
            StatusMessage = "Wniosek został zapisany pomyślnie";
            PokazWpisy();
            WyczyscFormularz();
        }
        catch (Exception ex)
        {
            StatusMessage = $"Błąd podczas zapisywania: {ex.Message}";
        }
        finally
        {
            IsLoading = false;
        }
    }

    private void PokazWpisy()
    {
        try
        {
            IsLoading = true;
            Wnioski.Clear();
            foreach (var w in _db.PobierzWnioski())
                Wnioski.Add(w);
            StatusMessage = $"Pobrano {Wnioski.Count} wpisów";
        }
        catch (Exception ex)
        {
            StatusMessage = $"Błąd podczas pobierania wpisów: {ex.Message}";
        }
        finally
        {
            IsLoading = false;
        }
    }

    private void WyczyscFormularz()
    {
        DataWypelnienia = null;
        NumerAlbumu = null;
        NazwiskoImie = null;
        SemestrRok = null;
        KierunekStopien = null;
        Przedmiot = null;
        Punkty = null;
        Prowadzacy = null;
        Uzasadnienie = null;
        DataPodpisStudenta = null;
        Decyzja = null;
        Komisja1 = null;
        Komisja2 = null;
        Komisja3 = null;
        DataDecyzji = null;
        StatusMessage = "Formularz został wyczyszczony";
    }
}
