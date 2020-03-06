using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RockPaperScissors.Model
{
    public enum RpsMode
    {
        [Display(Name = "Bez volby")]
        None = 0,
        [Display(Name = "Kámen")]
        Rock = 1,
        [Display(Name = "Papír")]
        Paper = 2,
        [Display(Name = "Nůžky")]
        Scissors = 3
    }
}
