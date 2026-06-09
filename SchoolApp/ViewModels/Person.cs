using System.ComponentModel;

namespace SchoolApp.ViewModels;

public class Person : INotifyPropertyChanged
{
    private string _name = "Aida";
    public string Name
    {
        get => _name;
        set
        {
            _name = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
        }
    }

    private string _city = "Almaty";
    public string City
    {
        get => _city;
        set
        {
            _city = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(City)));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}