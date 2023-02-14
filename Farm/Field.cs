using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cas;

namespace Farm
{
    public class Field
    {
        private int _id;
        private readonly IoHandler _ioHandler = IoHandler.Instance;
        private List<Animal> _animals;

        public Field(int id)
        {
            this._id = id;
            this._animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
            _ioHandler.PrintLine($"Add a new {animal} to field[{this._id}]");
        }

        public void ShowAnimals()
        {
            foreach (var animal in _animals)
            {
                _ioHandler.PrintLine($"{animal} is in field {this._id}");
            }
        }

        public void PetAnimals()
        {
            _ioHandler.PrintLine($"\n========[Petting animals in field {this._id}]========");
            foreach (var animal in _animals)
            {
                animal.Pet();
            }
        }

        public void FeedAnimals(string food)
        {
            _ioHandler.PrintLine($"\n========[Feeding animals in field {this._id}]========");
            foreach (var animal in _animals)
            {
                animal.Feed(food);
            }
        }
    }
}
