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
    public class MonsterTypeBLL : IRepo<MonsterType>
    {
        private MonsterTypeDAL _db;

        public MonsterTypeBLL()
        {
            _db = new MonsterTypeDAL();
        }

        public int Save(MonsterType monsterType)
        {
            int monsterTypeId = _db.Save(monsterType);
            return monsterTypeId;
        }

        public MonsterType Load(int monsterTypeId)
        {
            var monsterType = _db.Load(monsterTypeId);
            return monsterType;
        }

        public void Delete(int monsterTypeId)
        {
            _db.Delete(monsterTypeId);
        }
    }
}
