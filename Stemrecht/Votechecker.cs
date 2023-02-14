using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stemrecht
{
    public class Votechecker
    {
        public void Run(int input)
        {
            if (input == 18)
            {
                Console.WriteLine("Gefeliciteerd, je bent vanaf deze leeftijd stemgerechtigd");
            }
            else if (input > 18)
            {
                Console.WriteLine("Je bent stemgerechtigd.");
            }
            else
            {
                Console.WriteLine("Je bent niet stemgerechtigd");
            }
        }
    }
}