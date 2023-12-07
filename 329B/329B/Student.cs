namespace _329B;

public class Student
{
    public string Name;
    private List<Class1> _classes;

    public Student(string name)
    {
        Name = name;
        _classes = new List<Class1>();
    }

    public void RegisterClass(Class1 class1)
    {
        _classes.Add(class1);
    }
}

/*
 *     public string subjects;
   public string weekplan;
*/