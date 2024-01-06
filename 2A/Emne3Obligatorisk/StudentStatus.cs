namespace Emne3Obligatorisk;

public class StudentStatus
{
    public Status Status { get; private set; }
    private readonly Dictionary<Status, List<Status>> _allowedTransitions;
    public List<Status> StatusHistory { get; } = new List<Status>();

    public StudentStatus()
    {
        Status = Status.HarSøkt;
        StatusHistory.Add(Status);

        _allowedTransitions = new Dictionary<Status, List<Status>>
        {
            { Status.HarSøkt,             new List<Status> { Status.LevertDokumentasjon, Status.IkkeStartet }},
            { Status.LevertDokumentasjon, new List<Status> { Status.FåttTilbud, Status.IkkeStartet }},
            { Status.FåttTilbud,          new List<Status> { Status.SignertKontrakt, Status.IkkeStartet }},
            { Status.SignertKontrakt,     new List<Status> { Status.Startet, Status.IkkeStartet }},
            { Status.Startet,             new List<Status> { Status.Brutt, Status.FullførtIkkeBestått, Status.FullførtOgBestått }},
            { Status.FullførtIkkeBestått, new List<Status> { Status.IkkeBeståttIkkeFlereForsøk, Status.FullførtOgBestått }},
        };
    }

    public void ChangeStatus(Status newStatus)
    {
        if (IsTransitionAllowed(newStatus)) Status = newStatus;
    }

    private bool IsTransitionAllowed(Status newStatus)
    {
        if (_allowedTransitions.ContainsKey(Status))
        {
            List<Status> allowedTransitions = _allowedTransitions[Status];
            return allowedTransitions.Contains(newStatus);
        }
        return false;
    }
}