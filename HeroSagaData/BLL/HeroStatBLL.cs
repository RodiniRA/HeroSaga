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
    public class HeroStatBLL : IRepo<HeroStat>
    {
        private HeroStatDAL _db;

        public HeroStatBLL()
        {
            _db = new HeroStatDAL();
        }

        public int Save(HeroStat heroStat)
        {
            int heroStatId = _db.Save(heroStat);
            return heroStatId;
        }

        public HeroStat Load(int heroStatId)
        {
            var heroStat = _db.Load(heroStatId);
            return heroStat;
        }

        public void Delete(int heroStatId)
        {
            _db.Delete(heroStatId);
        }
    }
}
