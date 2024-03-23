using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


[assembly: InternalsVisibleTo("GUI")]

namespace LAB3
{
    internal class DanePogodowe
    {
        [Key]
        public int Id { get; set; }
        public Coord coord { get; set; } = new Coord();
        //public Weather[] weather { get; set; }= new Weather[0];
        public string @base { get; set; } = "";
        public Main main { get; set; } = new Main();
        public int visibility { get; set; }
        public Wind wind { get; set; } = new Wind();
        public Clouds clouds { get; set; }=new Clouds();
        public long dt { get; set; }
        public Sys sys { get; set; } = new Sys();
        public int timezone { get; set; }
        
        public string name { get; set; } = "";
        public int cod { get; set; }

        override public string ToString()
        {
            string output = 
                $"Miasto: {this.name}\n" +
                $"Kraj: {this.sys.country}\n" +
                $"Temperatura: {this.main.temp} C\n" +
                $"Wilgotność: {this.main.humidity}%\n" +
                $"Temperatura minimalna: {this.main.temp_min} C\n" +
                $"Temperatura maksymalna: {this.main.temp_max} C\n" +
                $"Długość geograficzna: {this.coord.lon}\n" +
                $"Szerokość geograficzna: {this.coord.lat}";

            return output;
        }
    }

    
}
