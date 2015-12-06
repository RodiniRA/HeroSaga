using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeroSaga.Models
{
    public class MonsterStat
    {
        public int MonsterStatId { get; set; }
        public int MonsterId { get; set; }
        public Stat Stat { get; set; }
        public decimal CurrentValue { get; set; }
        public bool IsActive { get; set; }
    }
}