using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    internal abstract class Animals
    {
        public string Name { get; set; }

        public Animals(string name)
        {
            Name = name;
        }

        public abstract string MakeSound();
    }
}
