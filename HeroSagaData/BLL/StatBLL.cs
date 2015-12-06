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
    public class StatBLL : IRepo<Stat>
    {
        private StatDAL _db;

        public StatBLL()
        {
            _db = new StatDAL();
        }

        public int Save(Stat stat)
        {
            int statId = _db.Save(stat);
            return statId;
        }

        public Stat Load(int statId)
        {
            var stat = _db.Load(statId);
            return stat;
        }

        public void Delete(int statId)
        {
            _db.Delete(statId);
        }
    }
}
