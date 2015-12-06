using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HeroSaga.Models;
using HeroSagaData.BLL;

namespace HeroSaga.Controllers
{
	public class CharacterController : Controller
	{
		private HeroBLL HeroRepo { get; set; }
		private BattleLogBLL BattleRepo { get; set; }

		public CharacterController()
		{
			HeroRepo = new HeroBLL();
			BattleRepo = new BattleLogBLL();
		}
		// GET: Character
		public ActionResult Index()
		{
			IEnumerable<Hero> heros = HeroRepo.GetAll();
			return View(heros);
		}

		public ActionResult Details(int id)
		{
			Hero hero = HeroRepo.Load(id);
			return View(hero);
		}
		public ActionResult Create()
		{
			var model = new CreateCharacterViewModel();
			var heroTypes = new List<HeroType>();
			ViewBag.AvailableHeroTypes = new SelectList(heroTypes, "HeroTypeId", "Name");
			return View(model);
		}
		[HttpPost]
		public ActionResult Create(Hero model)
		{
			var heroTypes = new List<HeroType>();
			ViewBag.AvailableHeroTypes = new SelectList(heroTypes, "HeroTypeId", "Name");
			return View(model);
		}

		public PartialViewResult Battles(int heroid)
		{
			var battles = BattleRepo.GetByHeroId(heroid);
			return PartialView(battles);

		}

		public PartialViewResult Stats(int heroid)
		{
			var stats = HeroRepo.GetHeroStatsByHeroId(heroid);
			return PartialView(stats);
			
		}
	}
}