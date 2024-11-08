using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    internal class Dog : Animals
    {
        public Dog(string name) : base(name) { }

        public override string MakeSound()
        {
            using (SoundPlayer player = new("dog.wav"))
            {
                player.PlaySync();
            }
            return "Vow";
        }
    }
}
