namespace Oblig_Oppgave_2a;

public class StudentStatus
{
    public State state { get; private set; }

    public StudentStatus()
    {
        state = State.HarSøkt;
    }

    public void ChangeStatus(State newStatus)
    {
        state = newStatus;
    }
}