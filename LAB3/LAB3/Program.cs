using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using static LAB3.Program;



namespace LAB3
{
    internal class Program
    {

            static void Main(string[] args)

            {
                APITest api = new APITest();

                while (true)
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1. Wpisz miasto");
                    Console.WriteLine("2. Usuń bazę danych");
                    Console.WriteLine("3. Wyjdź");
                Console.WriteLine("4. Wyswietl baze");
                Console.Write("Wybierz opcję: ");

                    string choice = Console.ReadLine();

                   var context = new Pogoda();

                switch (choice)
                    {
                        case "1":
                            Console.WriteLine("Podaj miasto\n");
                            string city = Console.ReadLine();
                            Console.WriteLine(api.HandlerDoApi(city));
                            break;
                        case "2":

                            context.WyczyscBazeDanych();
                        

                        break;
                        case "3":
                            Console.WriteLine("Do widzenia!");
                            return;
                        case "4":
                        Console.WriteLine("Zawartosc:\n");
                        Console.WriteLine(context.ToString());
                        break;
                        default:
                            Console.WriteLine("Nieprawidłowy wybór. Wybierz opcję od 1 do 4.");
                            break;
                    }

                    Console.WriteLine();
                }
            }

        }

    }



