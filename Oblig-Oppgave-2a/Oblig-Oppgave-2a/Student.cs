namespace Oblig_Oppgave_2a;

public class Student
{
    public string Name;
    public StudentStatus CurrentStatus;

    public Student(string name)
    {
        Name = name;
        CurrentStatus = new StudentStatus();
    }

    public void ChangeStatus(Status newStatus)
    {
        CurrentStatus.ChangeStatus(newStatus);
    }

    public string GetStatus()
    {
        return CurrentStatus.Status.ToString();
    }

    public bool CheckHistory(Status status)
    {
        foreach (var history in CurrentStatus.StatusHistory)
        {
            if (history == status)
            {
                return true;
            }
        }
        return false;
    }

}