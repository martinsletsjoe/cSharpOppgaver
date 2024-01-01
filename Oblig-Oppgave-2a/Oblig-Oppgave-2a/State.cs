namespace Oblig_Oppgave_2a;

public enum State
{
    HarSøkt,
    LevertDokumentasjon,
    FåttTilbud,
    SignertKontrakt,


    IkkeStartet,
    Startet,

    Brutt,
    FullførtIkkeBestått,

    IkkeBeståttIkkeFlereForsøk,
    FullførtOgBestått,
}

/* 
   // alltid på ikke startet, om signert kontrakt spør om de har startet.
   // om de har startet, har de fullført og bestått, eller har de brutt, fullført og ikke bestått,
   // ikke bestått og ikke flere forsøk igjen
*/