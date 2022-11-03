bool continua = true;

//Al momento loop
//while (continua)
//{
//    Console.WriteLine("Vuoi usare una [lavatrice/asciugatrice?]");
//    string risposta = Console.ReadLine();

//    switch (risposta)
//    {
//        case "lavatrice":
//            Console.WriteLine("Quale funzione vuoi utilizzare? ['rinfrescante','rinnovante', 'sgrassante']");

//            break;

//        case "asciugatrice":
//            Console.WriteLine("Quale funzione vuoi utilizzare? ['rapido','intenso']");


//            break ;
//    }
//}
Lavanderia Lavanderia2 = new Lavanderia();


public class Lavanderia
{
    private Lavatrice[] LavatriciPresenti;
    private Asciugatrice[] AsciugatriciPresenti;
    public int NumeroLavatriciPresenti { get; set; }
    public int NumeroAsciugatriciPresenti { get; set; }

  
    public Lavanderia()
    {
        LavatriciPresenti = new Lavatrice[5];
        AsciugatriciPresenti = new Asciugatrice[5];

    } 

    public Lavanderia(int massimoNummeroDiLavatriciDisponibili)
    {
        LavatriciPresenti = new Lavatrice[massimoNummeroDiLavatriciDisponibili];
        AsciugatriciPresenti = new Asciugatrice[massimoNummeroDiLavatriciDisponibili];

    }


}

//Saldo



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

    }

    // Variabili
    public string Nome { get; private set; }
    public bool Stato { get; set; }
    public Programmi ProgrammaSelezionato { get; set; }
    public int Detersivo { get; set; }
    public int Ammorbidente { get; set; }
    public int DurataLavaggio { get; set; }
}

public class Programmi
{
    // COSTRUTTORE
    public Programmi(string tipo, int costo, int durata, int consumoDetersivo, int consumoAmmorbidente)
    {
        Tipo = tipo;
        Costo = costo;
        Durata = durata;
        ConsumoDetersivo = consumoDetersivo;
        ConsumoAmmorbidente = consumoAmmorbidente;
    }


    // VARIABILI
    public int Costo { get; set; }
    public int Durata { get; set; }
    public int ConsumoDetersivo { get; set; }
    public int ConsumoAmmorbidente { get; set; }
    public string Tipo { get; }
}


public class Asciugatrice
{

    // Costruttore 
    public Asciugatrice(string nome, bool stato, Programmi programmaSelezionato, int durataDelLavaggio)
    {
        Nome = nome;
        Stato = stato;
        ProgrammaSelezionato = programmaSelezionato;
        DurataDelLavaggio = durataDelLavaggio;
    }


    // Variabili
    public string Nome { get; private set; }
    public bool Stato { get; set; }
    public Programmi ProgrammaSelezionato { get; set; }
    public int DurataDelLavaggio { get; set; }

    public int GuadagnoMacchine { get; set; }
}



