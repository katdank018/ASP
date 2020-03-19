using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RockPaperScissors.Model;
using RockPaperScissors.Services;

namespace P2RockPaperScissors.Pages
{
    public class IndexModel : PageModel
    {
        private readonly RpsLogic _rpsLogic;

        public IndexModel(RpsLogic rpsLogic)
        {
            _rpsLogic = rpsLogic;
        }

        public string Message { get; set; }

        [BindProperty]
        public Rps GameData { get; set; }

        [BindProperty]
        public RpsMode UserChoice { get; set; }

        public void OnGet()
        {
            GameData = _rpsLogic.userData;
        }

        public void OnPost()
        {            
            if (this.ModelState.IsValid)
            {
                _rpsLogic.userData = GameData;
                _rpsLogic.GameRound(UserChoice);
            }
            
        }
    }
}
