// See https://aka.ms/new-console-template for more information


bool continua = true;

while (continua)
{
    Console.WriteLine("Vuoi usare una [lavatrice/asciugatrice?]");
    string risposta = Console.ReadLine();

    switch (risposta)
    {
        case "lavatrice":
            Console.WriteLine("Quale funzione vuoi utilizzare? ['rinfrescante','rinnovante', 'sgrassante']");

            break;

        case "asciugatrice":
            Console.WriteLine("Quale funzione vuoi utilizzare? ['rapido','intenso']");
           

            break ;

    }

}



public class Lavanderia
{
    
    public int NumeroLavatriciPresenti { get; set; }
    public int NumeroAsciugatriciPresenti { get; set; }

    //public lavanderia()
    //{
    //    lavatricipresenti = new lavatrice[5];
    //    asciugatricipresenti = new asciugatrice[5];

    //}

    //public lavanderia(int massimonumerodilavatrici)
    //{
    //    lavatricipresenti = new lavatrice[massimonumerodilavatrici];
    //}

    //public asciugatrice(int massimonumerodiasciugatrici)
    //{
    //    asciugatricipresenti = new asciugatrice[massimonumerodiasciugatrici];
    //}
 
}

public class Lavatrice
{

    public string cost { get; set; }
    public string time { get; set; } 
    public string consumable { get; set; }
    
}


public class Asciugatrice
{


    public string cost { get; set; }
    public string time { get; set; }
    public string consumable { get; set; }

}
