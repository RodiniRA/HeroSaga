using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeroSaga.Models
{
    public class HeroStat
    {
        public int HeroStatId { get; set; }
        public int HeroId { get; set; }
        public Stat Stat { get; set; }
        public decimal CurrentValue { get; set; }
        public bool IsActive { get; set; }
    }
}