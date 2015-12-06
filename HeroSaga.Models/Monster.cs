using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeroSaga.Models
{
    public class Monster
    {
        public int MonsterId { get; set; }
        public MonsterType MonsterType { get; set; }
        public Origin Origin { get; set; }
        public int Level { get; set; }
        public int XPWorth { get; set; }
        public List<MonsterStat> Stats { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}