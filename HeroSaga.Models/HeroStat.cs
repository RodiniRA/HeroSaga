using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeroSaga.Models
{
    public class HeroStat
    {
			public int HeroStatId { get; set; }
			public int StatId { get; set; }
			public string CurrentValue { get; set; }
			public string StatName { get; set; }
	    public int HeroId { get; set; }
    }
}