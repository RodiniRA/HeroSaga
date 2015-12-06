using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroSaga.Models;
using HeroSagaData.DAL;
using HeroSagaData.Interfaces;

namespace HeroSagaData.BLL
{
    public class HeroBLL : IRepo<Hero>
    {
        private HeroDAL _db;

        public HeroBLL()
        {
            _db = new HeroDAL();
        }

        public int Save(Hero hero)
        {
            int heroId = _db.Save(hero);
            return heroId;
        }

        public Hero Load(int heroId)
        {
            var hero = _db.Load(heroId);
            return hero;
        }

        public void Delete(int heroId)
        {
            _db.Delete(heroId);
        }

	    public IEnumerable<Hero> GetAll()
	    {
		    return _db.GetAll();
	    }

	    public List<HeroStat> GetHeroStatsByHeroId(int heroid)
	    {
				return _db.GetHeroStatsByHeroId(heroid);
	    }
    }
}
