using SchoolApp.Models;
using SchoolApp.ViewModels;

namespace SchoolApp;

public partial class StudentsPage : ContentPage
{
    private readonly List<string> _students = new()
    {
        "Garifov Ilnur",
        "Kurmashev Artur",
        "Zhumabay Nurdaulet", 
    };

    private readonly StudentsViewModel _vm;

    public StudentsPage()
    {
        InitializeComponent();
        _vm = new StudentsViewModel();
        BindingContext = _vm;
    }
    private void OnAddClicked(object sender, EventArgs e)
    {
        _vm.AddStudent();
    }

    private async void OnStudentSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is not string name) return;
        await Shell.Current.GoToAsync($"{nameof(StudentsDetailPage)}?name={Uri.EscapeDataString(name)}");
        ((CollectionView)sender).SelectedItem = null;
    }
}