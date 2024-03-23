using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    internal class Coord
    {
        [Key]
        public int Id { get; set; }
        public float lon { get; set; }
        public float lat { get; set; }
    }
}
