namespace SchoolApp;

public partial class StudentsPage : ContentPage
{
    private readonly List<string> _students = new()
    {
        "Garifov Ilnur",
        "Kurmashev Artur",
        "Zhumabay Nurdaulet", 
    };

    public StudentsPage()
    {
        InitializeComponent();
        StudentsCollection.ItemsSource = _students;
    }

    private async void OnStudentSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is not string name) return;
        await Shell.Current.GoToAsync($"{nameof(StudentsDetailPage)}?name={Uri.EscapeDataString(name)}");
        ((CollectionView)sender).SelectedItem = null;
    }
}