
using DEMO09.DataInterfaces;
using DEMO09.DataLayerMSSQLWithEF;
using DEMO09.Types;
using System;
using System.Configuration;


namespace ConsoleAppTaxProfiles
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxProfileType item = new TaxProfileType();
            item.Identification = "GTR123456ABC";
            item.Name = "Empresa GTR S.A. de C.V.";
            item.Street = "Calle 1";
            item.ExteriorNumber = "123";
            item.InteriorNumber = "11";
            item.Suburb = "portales";
            item.State = "CDMX";
            item.PostCode = 01155;
            item.Country = "Mexico";

            //_connectionString = System.Configuration.con;


            //ITaxProfileRepository _TaxProfileRepository;
            //_TaxProfileRepository = new TaxProfileRepository("");




        }
    }
}
