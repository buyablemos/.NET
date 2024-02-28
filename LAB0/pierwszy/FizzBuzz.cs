using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pierwszy
{
    internal class FizzBuzz
    {
     int upperbound=15;

        public void Display()
        {
            for(int i=1; i <= upperbound; i++){

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else { Console.WriteLine(i);}
               

            }


        }
        public void Read()
        {
            Console.WriteLine("Podaj limit licznika w konsoli!");
            upperbound = Convert.ToInt32(Console.ReadLine());
        }

    }
}
