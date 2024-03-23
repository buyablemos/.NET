using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    internal class Wind
    {
        [Key]
        public int Id { get; set; }
        public float speed { get; set; }
        public int deg { get; set; }
        public float gust { get; set; }
    }
}
