using Newtonsoft.Json;
using System.Collections.Generic;
using static LAB3.Program;

namespace LAB3
{
    internal class Program
    {
        public class APITest
        {
            private
            HttpClient Client
            { set; get; } = new HttpClient();
            //string Response = "";
            List<DanePogodowe> dane_lista = new List<DanePogodowe>();
            DanePogodowe last = new DanePogodowe();
            public async Task GetData(string city)
            {
                Client = new HttpClient();
                string api_adress = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid=f327a510e6ee2f64efe6f5d217eb0748&units=metric";
                string Response = await Client.GetStringAsync(api_adress);
                last = JsonConvert.DeserializeObject<DanePogodowe>(Response);
                dane_lista.Add(last);
                return;
            }
            public void HandlerDoApi()
            {
                Console.WriteLine("Podaj miasto\n");
                string city = Console.ReadLine();

                var context = new Pogody();
                
                    city = FirstLetterToUpper(city);
                    PoorDanePogodowe existingItem = context.Baza.FirstOrDefault(obiekt => obiekt.name == city);

                    if (existingItem == null)
                    {
                        GetData(city).Wait(); // Wywołanie metody GetData asynchronicznie
                        PoorDanePogodowe tmp = new PoorDanePogodowe();
                        tmp.makePoor(last);
                        context.Baza.Add(tmp); // Dodanie ostatniego obiektu DanePogodowe z listy dane_lista do bazy danych
                        context.SaveChanges();
                        Console.WriteLine("Nowy obiekt został dodany do bazy danych.");
                        Console.WriteLine(dane_lista.Last().ToString());
                    }
                    else
                    {
                        Console.WriteLine("Obiekt o podanej nazwie już istnieje w bazie danych.\n\nOto obiekt wyciągnięty z bazy danych:\n");
                        Console.WriteLine(existingItem.ToString());
                    }
                
            }


            public static string FirstLetterToUpper(string str)
            {
                if (string.IsNullOrEmpty(str))
                    return str;

                char[] charArray = str.ToCharArray();
                charArray[0] = char.ToUpper(charArray[0]);
                return new string(charArray);
            }






            static void Main(string[] args)

            {
                APITest api = new APITest();

                while (true)
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1. Wpisz miasto");
                    Console.WriteLine("2. Usuń bazę danych");
                    Console.WriteLine("3. Wyjdź");
                    Console.Write("Wybierz opcję: ");

                    string choice = Console.ReadLine();


                    switch (choice)
                    {
                        case "1":
                            api.HandlerDoApi();
                            break;
                        case "2":
                            var context = new Pogody();
                            

                                context.WyczyscBazeDanych();

                            
                            break;
                        case "3":
                            Console.WriteLine("Do widzenia!");
                            return;
                        default:
                            Console.WriteLine("Nieprawidłowy wybór. Wybierz opcję od 1 do 3.");
                            break;
                    }

                    Console.WriteLine();
                }
            }

        }

    }
}


