using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RockPaperScissors.Model;

namespace RockPaperScissors
{

    public class LogikModel : PageModel
    {
        private Random random = new Random();
        [BindProperty]
        public int SecretNumber { get; private set; }
        [BindProperty]
        public int Number { get; private set; }
        [BindProperty]
        public int Max { get; private set; }
        [BindProperty]
        public int Min { get; private set; }
        [BindProperty]
        public GameState LastGuessState { get; private set; }
        [BindProperty]
        public int TipCounter { get; private set; }

        public void OnGet()
        {
            Max = 100;
            Min = 0;
            SecretNumber = random.Next(Min, Max);
            LastGuessState = GameState.None;
        }
        public void OnPost()
        {
            TipCounter++;
            if (SecretNumber == Number)
            {
                LastGuessState = GameState.IsEqual;
            }
            else if(SecretNumber > Number)
            {
                LastGuessState = GameState.IsGreater;
            }
            else if(SecretNumber < Number)
            {
                LastGuessState = GameState.IsLess;
            }
        }
    }
}