using System.Linq;
using System.Xml;

namespace SchoolApp;

[QueryProperty(nameof(Name), "name")]
public partial class StudentsDetailPage : ContentPage
{
    private string _name = string.Empty;

    public string Name
    {
        get => _name;
        set
        {
            _name = Uri.UnescapeDataString(value ?? string.Empty);
            NameLabel.Text = _name;

            int vowels = _name.Count(c => "aeiouаеёиоуыэюяәіүұөAEIOUАЕЁИОУЫЭЮЯ".Contains(c));
            FactLabel.Text = $"vowels in name: {vowels}  •  GPA: 3.7";
        }
    }

    public StudentsDetailPage()
    {
        InitializeComponent();
    }
}