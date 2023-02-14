using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cas;

namespace Farm
{
    public abstract class Animal
    {
        protected int _age;
        protected int _id;
        protected int _hunger = 50;
        protected bool _active = true;
        protected float _weight;
        protected string _prefix;
        protected string _preferredFood;
        protected static IoHandler _ioHandler = IoHandler.Instance;

        public Animal() { }
        public abstract void Feed(string food);
        public abstract void Pet();

        protected void CheckAlive()
        {
            if (_weight >= 100.0f || _hunger is <= 0 or > 100)
            {
                _active = false;
                _ioHandler.PrintLine($"{_prefix}Congratulations, you killed me.");
            }
        }
    }
}
