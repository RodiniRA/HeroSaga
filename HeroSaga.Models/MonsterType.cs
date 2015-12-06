using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeroSaga.Models
{
	public class MonsterType
    {
        public int MonsterTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}