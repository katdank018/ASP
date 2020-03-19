using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RockPaperScissors.Model;

namespace RockPaperScissors.Services
{
    public class RpsLogic
    {
        private readonly Random random;
        public RpsLogic(Random random)
        {
            this.random = random;
            userData = new Rps();
        }

        public Rps userData { get; set; }

        public void GameRound(RpsMode userChoice)
        {
            if (userChoice == RpsMode.None) return;
            RpsMode aiChoice = (RpsMode)random.Next(1, 4);
            userData.AiChoice = aiChoice;
            userData.UserChoice = userChoice;

            if (aiChoice == RpsMode.Rock && userChoice == RpsMode.Paper ||
                aiChoice == RpsMode.Paper && userChoice == RpsMode.Scissors ||
                aiChoice == RpsMode.Scissors && userChoice == RpsMode.Rock)
            {
                userData.WinCounter++;
                userData.IsWinner = true;
            }

            else if (aiChoice == userChoice)
            {
                userData.DrawCounter++;
                userData.IsWinner = null;
            }
            else
            {
                userData.LossCounter++;
                userData.IsWinner = false;
            }
        }
    }
}
