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
    public class MonsterStatBLL : IRepo<MonsterStat>
    {
        private MonsterStatDAL _db;

        public MonsterStatBLL()
        {
            _db = new MonsterStatDAL();
        }

        public int Save(MonsterStat monsterStat)
        {
            int monsterStatId = _db.Save(monsterStat);
            return monsterStatId;
        }

        public MonsterStat Load(int monsterStatId)
        {
            var monsterStat = _db.Load(monsterStatId);
            return monsterStat;
        }

        public void Delete(int monsterStatId)
        {
            _db.Delete(monsterStatId);
        }
    }
}
