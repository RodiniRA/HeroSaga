using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HeroSagaData.Interfaces
{
    public interface IRepo<T>
    {
        int Save(T model);
        T Load();
        void Delete(int id);
    }
}
