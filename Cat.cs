using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    internal class Cat : Animals
    {
        public Cat(string name) : base(name) { }

        public override string MakeSound()
        {
            using(SoundPlayer player = new("cat.wav"))
            {
                player.PlaySync();
            }
            return "Meau";
        }
    }
}
