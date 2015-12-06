using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroSaga.Models
{
	public class CreateCharacterViewModel
	{
		public string Name { get; set; }
		public string Gender { get; set; }
		[DisplayName("HeroName Type")]
		public int HeroTypeId { get; set; }
		public string Origin { get; set; }

	}
}
