namespace Emne3Obligatorisk;

public class Student
{
    public string Name { get; set;}
    public StudentStatus CurrentStatus { get; private set; }

    public Student(string name)
    {
        Name = name;
        CurrentStatus = new StudentStatus();
    }

    public string GetStatus()
    {
        return CurrentStatus.Status.ToString();
    }

    public void ChangeStatus(Status newStatus)
    {
        CurrentStatus.ChangeStatus(newStatus);
    }

    public bool CheckHistory(Status status)
    {
        foreach (var history in CurrentStatus.StatusHistory)
        {
            if (history == status) return true;
        }
        return false;
    }
}