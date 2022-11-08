
//Al momento loop
public class Lavatrice
{
    // Costruttore
   public Lavatrice(string nome, bool stato, Programmi programmaSelezionato, int detersivo, int ammorbidente, int durataLavaggio)
    {
        Nome = nome;
        Stato = stato;
        ProgrammaSelezionato = programmaSelezionato;
        Detersivo = detersivo;
        Ammorbidente = ammorbidente;
        DurataLavaggio = durataLavaggio;

        //Programma caricato
        caricato = new Programmi[4];
        caricato[0] = new Programmi("Spento", 0, 0, 0, 0);
        caricato[1] = new Programmi("Rinfrescante", 2, 20, 20, 5);
        caricato[2] = new Programmi("Rinnovante", 3, 40, 40, 10);
        caricato[3] = new Programmi("Sgrassante", 4, 60, 60, 15);
    }


    public void caricoCasuale()
    {
        Random rnd = new Random();
        int Programmi = rnd.Next(0, caricato.Length);
        ProgrammaSelezionato = caricato[Programmi];
        GuadagnoMacchine += ProgrammaSelezionato.Costo;
        Detersivo -= ProgrammaSelezionato.ConsumoDetersivo;
        Ammorbidente -= ProgrammaSelezionato.ConsumoAmmorbidente;
    }


  

    // Variabili

    public string Nome { get; private set; }
    public bool Stato { get; set; }
    public Programmi ProgrammaSelezionato { get; set; }
    public int Detersivo { get; set; }
    public int Ammorbidente { get; set; }
    public int DurataLavaggio { get; set; }
    public int GuadagnoMacchine { get; set; }

    public Programmi[] caricato;


}



