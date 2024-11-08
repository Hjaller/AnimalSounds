using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    internal class Sheep : Animals
    {
        public Sheep(string name) : base(name) { }

        public override string MakeSound()
        {
            using (SoundPlayer player = new("sheep.wav"))
            {
                player.PlaySync();
            }

            return "Baaaah";
        }
    }
}
