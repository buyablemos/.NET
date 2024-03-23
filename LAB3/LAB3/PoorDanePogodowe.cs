using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("GUI")]


namespace LAB3
{
    internal class PoorDanePogodowe
    {  
        
        public int Id { get; set; }

        public string name { get; set; } = "";
        public string country { get; set; } = "";
        public float temp { get; set; }
        public float humidity { get; set; }
        public float temp_min { get; set; }
        public float temp_max { get; set; }
        public float lon { get; set; }
        public float lat { get; set; }

        override public string ToString()
        {
            string output =
                $"Miasto: {this.name}\n" +
                $"Kraj: {this.country}\n" +
                $"Temperatura: {this.temp} C\n" +
                $"Wilgotność: {this.humidity}%\n" +
                $"Temperatura minimalna: {this.temp_min} C\n" +
                $"Temperatura maksymalna: {this.temp_max} C\n" +
                $"Długość geograficzna: {this.lon}\n" +
                $"Szerokość geograficzna: {this.lat}\n";

            return output;
        }



        public void makePoor(DanePogodowe danePogodowe)
        {
            

            this.name = danePogodowe.name;
            this.country = danePogodowe.sys.country;
            this.temp = danePogodowe.main.temp;
            this.humidity = danePogodowe.main.humidity;
            this.temp_min = danePogodowe.main.temp_min;
            this.temp_max = danePogodowe.main.temp_max;
            this.lon = danePogodowe.coord.lon;
            this.lat = danePogodowe.coord.lat;


            return;
        }
    }
}
