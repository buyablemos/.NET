using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
[assembly: InternalsVisibleTo("GUI")]


namespace LAB3
{
    internal class APITest
    {
        
           
            public HttpClient Client { get; set; } = new HttpClient();
            //string Response = "";
            public List<DanePogodowe> dane_lista { get; set; } = new List<DanePogodowe>();
            public DanePogodowe last { get; set; } = new DanePogodowe();
            public string error { get; set; } ="";

            public string output { get; set; } = "";
            
            public async Task GetData(string city)
            {
                Client = new HttpClient();
                string api_adress = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid=f327a510e6ee2f64efe6f5d217eb0748&units=metric";
            try
            {
                string Response = await Client.GetStringAsync(api_adress);
                last = System.Text.Json.JsonSerializer.Deserialize<DanePogodowe>(Response);
                dane_lista.Add(last);
                
            } 
            catch (HttpRequestException ex) {
                error += $"Wystąpił błąd HTTP: {ex.Message}\n";
                
            }
                return;
            }



            public string HandlerDoApi(string city)
            {
                string output = "";

                var context = new Pogoda();
                city = FirstLetterToUpper(city);
                PoorDanePogodowe existingItem = context.BazaPogodowa.FirstOrDefault(obiekt => obiekt.name == city);

            if (existingItem == null)
            {
                GetData(city).Wait();

                if (error == "")
                {
                    PoorDanePogodowe tmp = new PoorDanePogodowe();
                    tmp.makePoor(last);
                    context.BazaPogodowa.Add(tmp);
                    context.SaveChanges();
                    output += "Nowy obiekt został dodany do bazy danych.\n";
                    output += tmp.ToString();
                }
                else
                {
                    output = error;
                    return output;
                }
            }
            else if (existingItem.aktualnaDataCzas.Date != DateTime.Now.Date)
            {


                GetData(city).Wait();
                if (error == "")
                {
                    PoorDanePogodowe tmp = new PoorDanePogodowe();
                    tmp.makePoor(last);
                    context.BazaPogodowa.Add(tmp);
                    context.SaveChanges();
                    output += "Nowy obiekt został dodany do bazy danych.\n";
                    output += tmp.ToString();
                }
                else
                {
                    output = error;

                }
            }
            else
            {
                output += "Obiekt o podanej nazwie już istnieje w bazie danych.\n\nOto obiekt wyciągnięty z bazy danych:\n";
                output += existingItem.ToString();
            }
                return output;

            }
            
        public async Task HandlerDoApiGUI(string city)
        {


            //string output = "";
            bool cond = false;
            var context = new Pogoda();

            city = FirstLetterToUpper(city);
            PoorDanePogodowe existingItem = context.BazaPogodowa.FirstOrDefault(obiekt => obiekt.name == city && obiekt.aktualnaDataCzas.Date == DateTime.Now.Date);



            if (existingItem == null)
            {
                await GetData(city); // Wywołanie metody GetData asynchronicznie

                if (error == "")
                {
                    PoorDanePogodowe tmp = new PoorDanePogodowe();
                    tmp.makePoor(last);
                    context.BazaPogodowa.Add(tmp); 
                    context.SaveChanges();
                    output += "Nowy obiekt został dodany do bazy danych.\n";
                    output += tmp.ToString();
                }
                else
                {
                    output = error;

                }
            }
            
            else
            {
                output += "Obiekt o podanej nazwie już istnieje w bazie danych.\n\nOto obiekt wyciągnięty z bazy danych:\n";
                output += existingItem.ToString();
            }


            return;
        }




            public string FirstLetterToUpper(string str)
            {
                if (string.IsNullOrEmpty(str))
                    return str;

                char[] charArray = str.ToCharArray();
                charArray[0] = char.ToUpper(charArray[0]);
                return new string(charArray);
            }

        }
    }
