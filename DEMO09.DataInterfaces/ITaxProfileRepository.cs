using DEMO09.Types;
using System.Collections.Generic;

namespace DEMO09.DataInterfaces
{
    public interface ITaxProfileRepository //: IRepositoryCRUD
    {

        int AddTaxProfile(TaxProfileType item);

        int RemoveTaxProfile(int Id);

        TaxProfileType FindTaxProfileByIdentification(string Identification);

        int UpdateTaxProfile(TaxProfileType item);

        IEnumerable<TaxProfileType> FindAllTaxProfiles();

        TaxProfileType FindTaxProfileById(int Id);

    }
}
