using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Goat : Animal
    {
        public Goat(int age, int id)
        {
            this._age = age;
            this._preferredFood = "carrot";
            this._weight = 40.75f;
            this._id = id;
            this._prefix = $"{this} [{this._id}]:";
        }

        public override void Feed(string food)
        {
            if (_active)
            {
                if (_hunger >= 90)
                {
                    _ioHandler.PrintLine($"{_prefix} I am not hungry, go away.");
                }
                else
                {
                    if (food == _preferredFood)
                    {
                        _ioHandler.PrintLine($"{_prefix} the goat loves this food!");
                    }

                    _hunger += 15;
                    _weight += 0.5f;
                    _ioHandler.PrintLine(
                        $"{_prefix} I have been fed, my hunger now is {_hunger} and I weigh {_weight}.");
                }
                CheckAlive();
            }
            else
            {
                _ioHandler.PrintLine("Stop feeding a dead animal");
            }
        }

        public override void Pet()
        {
            if (_active)
            {
                _ioHandler.PrintLine($"{_prefix} do not pet the goats!");
                _active = false;
                CheckAlive();
            }
            else
            {
                _ioHandler.PrintLine("Stop petting a dead animal.");
            }

        }
    }
}
