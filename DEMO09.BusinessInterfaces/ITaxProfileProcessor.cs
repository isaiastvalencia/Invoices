using DEMO09.Types;
using System.Collections.Generic;

namespace DEMO09.BusinessInterfaces
{
    public interface ITaxProfileProcessor
    {
        void AddTaxProfile(TaxProfileType item);

        IEnumerable<TaxProfileType> FindAllTaxProfiles();

        TaxProfileType FindTaxProfileById(int Id);

        TaxProfileType FindTaxProfileByIdentification(string Identification);

        void RemoveTaxProfile(int Id);

        void UpdateTaxProfile(TaxProfileType item);

    }
}
