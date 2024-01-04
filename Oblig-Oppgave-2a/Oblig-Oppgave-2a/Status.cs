namespace Oblig_Oppgave_2a;

public enum Status
{
    [LegalStatusChanges(LevertDokumentasjon, IkkeStartet)]
    HarSøkt,

    [LegalStatusChanges(FåttTilbud, IkkeStartet)]
    LevertDokumentasjon,

    [LegalStatusChanges(SignertKontrakt, IkkeStartet)]
    FåttTilbud,

    [LegalStatusChanges(Startet, IkkeStartet)]
    SignertKontrakt,

    IkkeStartet,

    [LegalStatusChanges(Brutt, FullførtIkkeBestått, FullførtOgBestått)]
    Startet,

    Brutt,

    [LegalStatusChanges(IkkeBeståttIkkeFlereForsøk, FullførtOgBestått)]
    FullførtIkkeBestått,

    IkkeBeståttIkkeFlereForsøk,

    FullførtOgBestått,
}

/* 
   // alltid på ikke startet, om signert kontrakt spør om de har startet.
   // om de har startet, har de fullført og bestått, eller har de brutt, fullført og ikke bestått,
   // ikke bestått og ikke flere forsøk igjen
*/