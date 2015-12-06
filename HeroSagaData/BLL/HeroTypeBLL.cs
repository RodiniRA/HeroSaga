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
    public class HeroTypeBLL : IRepo<HeroType>
    {
        private HeroTypeDAL _db;

        public HeroTypeBLL()
        {
            _db = new HeroTypeDAL();
        }

        public int Save(HeroType heroType)
        {
            int heroTypeId = _db.Save(heroType);
            return heroTypeId;
        }

        public HeroType Load(int heroTypeId)
        {
            var heroType = _db.Load(heroTypeId);
            return heroType;
        }

        public void Delete(int heroTypeId)
        {
            _db.Delete(heroTypeId);
        }
    }
}
