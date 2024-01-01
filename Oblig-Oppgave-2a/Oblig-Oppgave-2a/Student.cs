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

    //public State ChangeStatus(string newStatus)
    //{
    //    //return CurrentStatus.state == aState;
    //}
}