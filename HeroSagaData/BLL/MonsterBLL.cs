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
    public class MonsterBLL : IRepo<Monster>
    {
        private MonsterDAL _db;

        public MonsterBLL()
        {
            _db = new MonsterDAL();
        }

        public int Save(Monster monster)
        {
            int monsterId = _db.Save(monster);
            return monsterId;
        }

        public Monster Load(int monsterId)
        {
            var monster = _db.Load(monsterId);
            return monster;
        }

        public void Delete(int monsterId)
        {
            _db.Delete(monsterId);
        }
    }
}
