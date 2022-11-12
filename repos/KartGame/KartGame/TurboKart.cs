using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartGame
{
    internal class TurboKart : Kart
    {
        public void Turbo()
        {
            Console.WriteLine("ブースト！");
        }

        public override void Horn()
        {
            Console.WriteLine("C");
        }
    }
}
