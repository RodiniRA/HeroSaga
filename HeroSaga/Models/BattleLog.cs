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
        public Monster Monster { get; set; }
        public Hero Hero { get; set; }
        public bool VictoryStatus { get; set; }
        public bool IsActive { get; set; }
    }
}