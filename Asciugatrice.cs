
//Al momento loop
public class Asciugatrice
{

    // Costruttore 
    public Asciugatrice(string nome, bool stato, Programmi programmaSelezionato, int durataDelLavaggio)
    {
        Nome = nome;
        Stato = stato;
        ProgrammaSelezionato = programmaSelezionato;
        DurataDelLavaggio = durataDelLavaggio;

        caricato = new Programmi[3];
        caricato[0] = new Programmi("Spento", 0, 0, 0, 0);
        caricato[1] = new Programmi("Rapido", 2, 20, 0, 0);
        caricato[2] = new Programmi("Intenso", 4, 40, 0, 0);
    }



    public void caricoCasuale()
    {
        Random rnd = new Random();
        int Programmi = rnd.Next(0, caricato.Length);
        ProgrammaSelezionato = caricato[Programmi];
        GuadagnoMacchine += ProgrammaSelezionato.Costo;
    }

    // Variabili
    public Programmi[] caricato;
    public string Nome { get; private set; }
    public bool Stato { get; set; }
    public Programmi ProgrammaSelezionato { get; set; }
    public int DurataDelLavaggio { get; set; }

    public int GuadagnoMacchine { get; set; }
}



