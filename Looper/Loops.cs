using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looper
{
    public class Loops
    {
        private readonly IoHandler _io;

        public Loops()
        {
            _io = IoHandler.Instance;
        }
        public void ForLoop()
        {
            _io.Print("Dit is een for loop.\nVul een getal in: ");
            int target = _io.GetInt();

            for (int i = 0; i < target; i++)
            {
                _io.PrintLine($"Dit is een loop! {i + 1}");
            }
        }

        public void DoWhileLoop()
        {
            _io.Print("Dit is een do-while loop.\nVul een getal in: ");
            int iterator = 0;
            int target = _io.GetInt();

            do
            {
                _io.PrintLine($"Dit is een loop! {iterator + 1}");
                iterator++;
            } while (iterator < target);
        }

        public void WhileLoop()
        {
            _io.Print("Dit is een while loop.\nVul een getal in: ");
            int iterator = 0;
            int target = _io.GetInt();
            while(iterator < target) 
            {
                _io.PrintLine($"Dit is een loop! {iterator + 1}");
                iterator++;
            }
        }
    }
}
