using System;
using System.Diagnostics;
using System.Reflection.PortableExecutable;

bool continua = true;

Lavanderia lavanderia = new Lavanderia();

//Al momento loop
while (continua)
{
    Console.WriteLine("Vuoi usare una [lavatrice/asciugatrice?]");
    string risposta = Console.ReadLine();

    switch (risposta)
    {
        case "macchina":
            lavanderia.Macchina();
            break;


        case "lavatrice":
            Console.WriteLine("Quale funzione vuoi utilizzare? [1)rinfrescante2) rinnovante 3) sgrassante]");
            int lavaggio = Convert.ToInt32(Console.ReadLine());
            switch(lavaggio)
            {
                case 1:
                    Console.WriteLine("Complimenti stai utilizzando un nest switch");
                    lavanderia.Macchina();
                    continua = false;
                    break;

                case 2:
                    Console.WriteLine("Complimenti stai utilizzando un nest switch 2");
                    continua = false;
                    break;

                case 3:
                    Console.WriteLine("Complimenti stai utilizzando un nest switch 3");
                    continua = false;
                    break;
            }
            continua = false;
            break;

        case "asciugatrice":
            Console.WriteLine("Quale funzione vuoi utilizzare? [1) 'rapido', 2)'intenso']");
            int asciugatura = Convert.ToInt32(Console.ReadLine());
            switch (asciugatura)
            {
                case 1:
                    Console.WriteLine("Complimenti stai utilizzando un nest switch");
                    continua = false;
                    break;
                case 2:
                    Console.WriteLine("Complimenti stai utilizzando un nest switch 2");
                    continua = false;
                    break;
            }
            continua = false;
            break;
    }
}




