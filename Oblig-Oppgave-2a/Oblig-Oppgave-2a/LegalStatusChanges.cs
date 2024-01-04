namespace Oblig_Oppgave_2a;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
public class LegalStatusChangesAttribute : Attribute
{
    public Status[] AllowedStates { get; private set; }

    public LegalStatusChangesAttribute(params Status[] allowedStates)
    {
        AllowedStates = allowedStates;
    }
}