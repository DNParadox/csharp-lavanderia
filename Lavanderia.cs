using System.ComponentModel;

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
            LavatriciPresenti[i] = new Lavatrice("Lavatrice " + (i + 1), true, null, 1000, 500, 0);
            LavatriciPresenti[i].caricoCasuale();
        }
        for (int i = 0; i < 5; i++)
        {
            AsciugatriciPresenti[i] = new Asciugatrice("Asciugatrice", true, null, 0);
            AsciugatriciPresenti[i].caricoCasuale();
            
        }
    }

    public void logicaMacchina()
    {
        Console.WriteLine("Benvenuto nel Terminale");
        Console.WriteLine("1) Vuoi controllare lo stato delle macchine?");
        Console.WriteLine("2) Asciugatrice");
        Console.WriteLine("3) Lavatrice");
        Console.WriteLine("4) Quanti guadagni ha generato?");
        int risposta = Convert.ToInt32(Console.ReadLine());

        switch (risposta)
        {
            case 1:
                // Lavatrici
                for (int i = 0; i < LavatriciPresenti.Length; i++)
                {
                    LogicaLavatrice();
                    if (AsciugatriciPresenti[i].Stato != false)
                    {
                        Console.WriteLine("La " + LavatriciPresenti[i].Nome + " è in funzione");
                    }
                    else
                    {
                        Console.WriteLine("La " + LavatriciPresenti[i].Nome + " Non è in funzione");
                    }
                }

                // Asciugatrici
                for (int i = 0; i < AsciugatriciPresenti.Length; i++)
                {
                    if (AsciugatriciPresenti[i].Stato != false)
                    {
                        Console.WriteLine("L' " + AsciugatriciPresenti[i].Nome + " è in funzione");
                    }
                    else
                    {
                        Console.WriteLine("L' " + AsciugatriciPresenti[i].Nome + " Non è in funzione");
                    }
                }
                break;
            case 2:

                LogicaLavatrice();
                break;
            case 3:
                // Asciugatrici
                for (int i = 0; i < AsciugatriciPresenti.Length; i++)
                {
                    if (AsciugatriciPresenti[i].Stato)
                    {
                        Console.WriteLine("L' " + AsciugatriciPresenti[i].Nome + " è in funzione");
                    }
                    else
                    {
                        Console.WriteLine("L' " + AsciugatriciPresenti[i].Nome + " Non è in funzione");
                    }
                }
                break;
           
            //case 3:
            //    LogicaAsciugatrice();
            //    break;
            case 4:
                Guadagno();
                break;

            case 5:
               
                break;
            default:
                Console.WriteLine("Error");
                break;

        }
    }
                public void LogicaLavatrice()
                {
                    // Riusciamo a passare su false la prima lavatrice, trovare metodo per selezionare, in modo procedurale le altre
                    for (int i = 0; i < LavatriciPresenti.Length; i++)
                    {
                        if (LavatriciPresenti[i].Stato != false)
                        {
                            Console.WriteLine("La " + LavatriciPresenti[i].Nome + " è Disponibile, vuoi utilizzarla? ['y/n'] ");
                            string Chose = Console.ReadLine();
                            if (Chose == "y")
                            {
                                // Pusho le lavatrici che sono disponibili 
                                if (LavatriciPresenti[i].Stato != false)
                                {
                                    Console.WriteLine("Abbiamo scelto per te il lavaggio: " + LavatriciPresenti[i].ProgrammaSelezionato.Tipo);
                                    Console.WriteLine("Il programma durerà: " + LavatriciPresenti[i].ProgrammaSelezionato.Durata + " minuti");
                                    LavatriciPresenti[i].Stato = false;
                                    logicaMacchina();
                                }
                                else
                                {
                                    Console.WriteLine("Lavatrici Tutte in uso, aspetta.");
                                    logicaMacchina();
                                }
                            }
                           
                        }
                        else
                        {
                            Console.WriteLine("La " + LavatriciPresenti[i].Nome + " Non è Disponibile");
                        }
                    }
                }

                public void Guadagno()
                {
                    float guadagno = 0;
                    float guadagnoLav = 0;
                    float guadagnoAsc = 0;
                    for (int i = 0; i < LavatriciPresenti.Length; i++)
                    {
                        guadagnoLav += LavatriciPresenti[i].GuadagnoMacchine;
                        guadagnoAsc += AsciugatriciPresenti[i].GuadagnoMacchine;
                        guadagno = guadagnoLav + guadagnoAsc;
                    }

                    Console.WriteLine("La somma è " + guadagnoLav / 2 + " Euro");
                    Console.WriteLine("La somma è " + guadagnoAsc / 2 + " Euro");
                    Console.WriteLine("La somma totale è " + guadagno / 2 + " Euro");
                
                    logicaMacchina();
                }
        }
    









