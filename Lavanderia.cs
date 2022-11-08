public class Lavanderia
{
    private Lavatrice[] LavatriciPresenti;
    private Asciugatrice[] AsciugatriciPresenti;
  
  
    public Lavanderia()
    {
        LavatriciPresenti = new Lavatrice[5];
        AsciugatriciPresenti = new Asciugatrice[5];

        for (int i = 0; i < 5; i++)
        {
            LavatriciPresenti[i] = new Lavatrice("Lavatrice" + (i + 1),true, null, 1000, 500, 0);
            LavatriciPresenti[i].caricoCasuale();
        }


        for( int i = 0; i < 5; i++)
        {
            AsciugatriciPresenti[i] = new Asciugatrice("Asciugatrice", true, null, 0);
        }
    } 


    public void Macchina()
    {
        for (int i = 0; i < LavatriciPresenti.Length; i++)
        {
            // Pusho le lavatrici che sono disponibili 
            if (LavatriciPresenti[i].Stato)
            {
                // Una volta effettuato il controllo, chiedo all'utente quale utilizzare
                Console.WriteLine(LavatriciPresenti[i].Nome + "Quale vuoi utilizzare?" );
                int risposta = Convert.ToInt32(Console.ReadLine());
                switch (risposta)
                {
                    case 1:
                        Console.WriteLine("Quale Lavaggio vuoi utilizzare?");
                        Console.WriteLine(LavatriciPresenti);

                    break;

                }
                break;
            }
        }
    }


}



