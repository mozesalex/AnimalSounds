using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds.AnimalModels
{
    class Cat : IAnimal
    {
        public string MakeSound() => "Meow";
    }
}
