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
    public class OriginBLL : IRepo<Origin>
    {
        private OriginDAL _db;

        public OriginBLL()
        {
            _db = new OriginDAL();
        }

        public int Save(Origin origin)
        {
            int originId = _db.Save(origin);
            return originId;
        }

        public Origin Load(int originId)
        {
            var origin = _db.Load(originId);
            return origin;
        }

        public void Delete(int originId)
        {
            _db.Delete(originId);
        }
    }
}
