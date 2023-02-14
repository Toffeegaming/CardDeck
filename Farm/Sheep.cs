using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Sheep : Animal
    {
        public Sheep(int age, int id)
        {
            this._age = age;
            this._preferredFood = "hay";
            this._weight = 70.5f;
            this._id = id;
            this._prefix = $"{this} [{this._id}]:";
        }

        public override void Feed(string food)
        {
            if (this._active)
            {
                if (_hunger >= 90)
                {
                    _ioHandler.PrintLine($"{_prefix} I am not hungry.");
                }
                else
                {
                    if (food == _preferredFood)
                    {
                        _ioHandler.PrintLine($"{_prefix} BEEEEEEHHHHHH! (I love this food!)");
                    }

                    _hunger += 10;
                    _weight += 0.5f;
                    _ioHandler.PrintLine($"{_prefix} I have been fed, my hunger now is {_hunger} and I weigh {_weight}.");
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
                _hunger -= 15;
                _ioHandler.PrintLine($"{_prefix} BEEEHHHHHH! (Thank you for petting me!)\nMy hunger went down to {_hunger}");
                CheckAlive();
            }
            else
            {
                _ioHandler.PrintLine("Stop petting a dead animal.");
            }
        }
    }
}
