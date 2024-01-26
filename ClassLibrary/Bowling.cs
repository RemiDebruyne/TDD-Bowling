using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Bowling
    {
        private Random _rnd = new Random();
        public int Score { get; set; }
        public int Frame {  get; set; }

        public int Quilles { get; set; }

        public int Roll(int fallenPin)
        {
            if (fallenPin < 0)
                throw new NotBelowZeroException("Vous ne pouvez pas faire tomber un nombre de quilles négatif");
        }

        public int GetScore()
        {
            throw new NotImplementedException();
        }
    }
}
