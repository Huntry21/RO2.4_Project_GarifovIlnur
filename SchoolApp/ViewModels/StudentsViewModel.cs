using System.Collections.ObjectModel;
using SchoolApp.Models;

namespace SchoolApp.ViewModels;

public class StudentsViewModel
{
    public ObservableCollection<Student> Students { get; } = new();

    public string NewName { get; set; } = "";

    public StudentsViewModel()
    {
        // initial mock data — same five students as L14, now with GPA
        Students.Add(new Student { Name = "Aida Tulegenova", Gpa = 3.85 });
        Students.Add(new Student { Name = "Bekzat Sarsenov", Gpa = 3.20 });
        Students.Add(new Student { Name = "Dana Iskakova", Gpa = 3.95 });
        Students.Add(new Student { Name = "Erlan Nurpeisov", Gpa = 2.75 });
        Students.Add(new Student { Name = "Madina Akhmetova", Gpa = 3.60 });
    }

    public void AddStudent()
    {
        if (string.IsNullOrWhiteSpace(NewName)) return;
        Students.Add(new Student { Name = NewName, Gpa = 3.0 });
        NewName = "";
    }
}