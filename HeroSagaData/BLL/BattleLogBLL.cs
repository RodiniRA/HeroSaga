using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroSagaData.Interfaces;
using HeroSaga.Models;
using HeroSagaData.DAL;

namespace HeroSagaData.BLL
{
    public class BattleLogBLL : IRepo<BattleLog>
    {
        private BattleLogDAL _db;

        public BattleLogBLL()
        {
            _db = new BattleLogDAL();
        }

        public int Save(BattleLog battleLog)
        {
            int battleLogId = _db.Save(battleLog);
            return battleLogId;
        }

        public BattleLog Load(int id)
        {
            var battleLog = _db.Load(id);
            return battleLog;
        }

        public void Delete(int battleLogId)
        {
            _db.Delete(battleLogId);
        }

	    public IEnumerable<BattleLog> GetByHeroId(int heroid)
	    {

		    return _db.GetByHeroId(heroid);
	    }
    }
}
