namespace Oblig_Oppgave_2a;

public class StudentStatus
{
    public Status Status { get; private set; }
    public List<Status> StatusHistory { get; } = new List<Status>();
    
    public StudentStatus()
    {
        Status = Status.HarSøkt;
        StatusHistory.Add(Status);
    }

    public void ChangeStatus(Status newStatus)
    {
        if (IsStatusChangeLegal(newStatus))
        {
            Status = newStatus;
            StatusHistory.Add(newStatus);
        }
    }

    private bool IsStatusChangeLegal(Status newStatus)
    {
        var fieldInfo = Status.GetType().GetField(Status.ToString());
        var attributes = Attribute.GetCustomAttributes(fieldInfo);

        foreach (var attribute in attributes)
        {
            if (attribute is LegalStatusChangesAttribute legalStatusChangesAttribute)
            {
                if (legalStatusChangesAttribute.AllowedStates.Contains(newStatus))
                {
                    return true;
                }
            }
        }
        return false;
    }
}