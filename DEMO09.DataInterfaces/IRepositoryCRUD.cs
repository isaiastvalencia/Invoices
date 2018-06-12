using DEMO09.Types;
using System.Collections.Generic;
using System.Linq;

namespace DEMO09.DataInterfaces
{
    public interface IRepositoryCRUD
    {
        int Add<T>(T entitie);
        int Update<T>(T entitie);
        int Delete<T>(int Id);
        T FindById<T>(int Id);

        //int Add(TaxProfileType entitie);
        //int Update(TaxProfileType entitie);
        //int Delete(string Id);
        //IEnumerable<TaxProfileType> FindById(int Id);

    }
}
