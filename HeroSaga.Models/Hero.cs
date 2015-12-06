using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeroSaga.Models
{
    public class Hero
    {
        public int HeroId { get; set; }
        public HeroType HeroType { get; set; }
        public Origin Origin { get; set; }
        public int Level { get; set; }
        public int CurrentXP { get; set; }
        public string Gender { get; set; }
        public List<HeroStat> Stats { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

    }
}