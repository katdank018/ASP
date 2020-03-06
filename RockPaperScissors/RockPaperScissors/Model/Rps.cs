using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissors.Model
{
    public class Rps
    {
        public Rps(int winCounter = 0, int lossCounter = 0, int drawCounter = 0)
        {
            WinCounter = winCounter;
            LossCounter = lossCounter;
            DrawCounter = drawCounter;
            IsWinner = null;
        }

        public bool? IsWinner { get; set; }
        public int WinCounter { get; set; }
        public int LossCounter { get; set; }
        public int DrawCounter { get; set; }

    }
}
