namespace _329B;

public class Class1
{
    public string _className;
    public List<Student> _students = new List<Student>();
    private Subject _subject;


    public Class1(string className, Subject subject)
    {
        _className = className;
        _subject = subject;
        _students = new List<Student>();
    }


    public void RegisterStudent(Student student)
    {
        _students.Add(student);
        student.RegisterClass(this);
    }

    //public void ShowSubject()
    //{
        
    //    foreach (var subject in _Subjects)
    //    {
    //        Console.WriteLine(subject._name);
    //    }
    //}

    

    //public void AddStudent(string name)
    //{
    //    _students.Add(new Student(name));
    //}


    //public void ShowStudentInfo()
    //{
    //    Console.Clear();
    //    for (var index = 0; index < _students.Count; index++)
    //    {
    //        var student = _students[index];
    //        var subjects = _Subjects[index];
    //        Console.WriteLine(student.Name +" " + subjects.Name);
    //    }
    //}
}