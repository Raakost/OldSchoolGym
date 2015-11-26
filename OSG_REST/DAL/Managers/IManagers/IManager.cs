using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Managers.IManagers
{
    public interface IManager<T>
    {
        IEnumerable<T> ReadAll();

        T ReadByID(int Id);

        T Create(T model);

        Boolean Delete(T model);

        T Update(T model);
    }
}
