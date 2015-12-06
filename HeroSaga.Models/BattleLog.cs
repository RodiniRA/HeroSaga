using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeroSaga.Models
{
    public class BattleLog
    {
        public int BattleLogId { get; set; }
        public DateTime BattleDate { get; set; }
        public string MonsterName { get; set; }
        public string HeroName { get; set; }
        public bool VictoryStatus { get; set; }
				public int HeroID { get; set; }
	    public int MonsterId { get; set; }
	    public int XPWorth { get; set; }
    }
}