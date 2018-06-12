
using DEMO09.DataInterfaces;
using DEMO09.Types;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Configuration;

namespace DEMO09.DataLayerMSSQLWithEF
{
    public class TaxProfileRepository : ITaxProfileRepository
    {
        private readonly string _connectionString;

        public TaxProfileRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AgileInvoice"].ConnectionString;
        }

        public int AddTaxProfile(TaxProfileType item)
        {
            int result = 0;
            using (var context = new AgileInvoiceDbContext(_connectionString))
            {
                TaxProfile entitie = new TaxProfile();
                entitie.Name = item.Name;
                entitie.Identification = item.Identification;
                entitie.Street = item.Street;
                entitie.ExteriorNumber = item.ExteriorNumber;
                entitie.InteriorNumber = item.InteriorNumber;
                entitie.Suburb = item.Suburb;
                entitie.Municipality = item.Municipality;
                entitie.State = item.State;
                entitie.Country = item.Country;
                entitie.PostCode = item.PostCode;
                entitie.CreationDate = DateTime.Now;

                context.TaxProfiles.Add(entitie);
                result = context.SaveChanges();
            }
            return result;
        }

        public int RemoveTaxProfile(int Id)
        {
            int result = 0;
            using (var context = new AgileInvoiceDbContext(_connectionString))
            {
                //IQueryable<TaxProfile> lista = context.TaxProfiles.Select(item => item.Identification == Identification).ToList();
                IQueryable<TaxProfile> lista = from row in context.TaxProfiles
                                               where row.IdTaxProfile == Id
                                               select row;
                if (lista.Count() > 0)
                {
                    context.TaxProfiles.Remove(lista.FirstOrDefault());
                    result = context.SaveChanges();
                }
            }
            return result;
        }

        public IEnumerable<TaxProfileType> FindAllTaxProfiles()
        {
            IEnumerable<TaxProfileType> lista = null;
            //IQueryable<TaxProfile> lista = null; //NOTA: no se utiliza el IQueryable porque estamos convirtiendo a  TaxProfileType y no TaxProfile como es por default.
            using (var context = new AgileInvoiceDbContext(_connectionString))
            {
                lista = from row in context.TaxProfiles
                        select new TaxProfileType
                        {
                            IdTaxProfile = row.IdTaxProfile,
                            Name = row.Name,
                            Identification = row.Identification,
                            Street = row.Street,
                            ExteriorNumber = row.ExteriorNumber,
                            InteriorNumber = row.InteriorNumber,
                            Suburb = row.Suburb,
                            Municipality = row.Municipality,
                            State = row.State,
                            Country = row.Country,
                            PostCode = row.PostCode
                        };
                lista = lista.ToList();// sino se hace .ToList() marca un Error: "The operation cannot be completed because the DbContext has been disposed."
            }
            return lista;
        }

        public TaxProfileType FindTaxProfileByIdentification(string Identification)
        {
            TaxProfileType item = null;
            using (var context = new AgileInvoiceDbContext(_connectionString))
            {
                IQueryable<TaxProfile> lista = from row in context.TaxProfiles
                                               where row.Identification == Identification
                                               select row;
                if (lista.Count() > 0)
                {
                    var entitie = lista.FirstOrDefault();
                    item.IdTaxProfile = entitie.IdTaxProfile;
                    item.Name = entitie.Name;
                    item.Identification = entitie.Identification;
                    item.Street = entitie.Street;
                    item.ExteriorNumber = entitie.ExteriorNumber;
                    item.InteriorNumber = entitie.InteriorNumber;
                    item.Suburb = entitie.Suburb;
                    item.Municipality = entitie.Municipality;
                    item.State = entitie.State;
                    item.Country = entitie.Country;
                    item.PostCode = entitie.PostCode;
                }
            }
            return item;
        }

        public TaxProfileType FindTaxProfileById(int Id)
        {
            TaxProfileType item = null;
            using (var context = new AgileInvoiceDbContext(_connectionString))
            {
                IQueryable<TaxProfile> lista = from row in context.TaxProfiles
                                               where row.IdTaxProfile == Id
                                               select row;
                if(lista.Count() > 0)
                {
                    TaxProfile entitie = lista.FirstOrDefault();
                    item = new TaxProfileType();
                    item.IdTaxProfile = entitie.IdTaxProfile;
                    item.Name = entitie.Name;
                    item.Identification = entitie.Identification;
                    item.Street = entitie.Street;
                    item.ExteriorNumber = entitie.ExteriorNumber;
                    item.InteriorNumber = entitie.InteriorNumber;
                    item.Suburb = entitie.Suburb;
                    item.Municipality = entitie.Municipality;
                    item.State = entitie.State;
                    item.Country = entitie.Country;
                    item.PostCode = entitie.PostCode;
                }
            }
            return item;
        }

        public int UpdateTaxProfile(TaxProfileType item)
        {
            int result = 0;
            using (var context = new AgileInvoiceDbContext(_connectionString))
            {
                IQueryable<TaxProfile> lista = from row in context.TaxProfiles
                                               where row.IdTaxProfile == item.IdTaxProfile
                                               select row;
                if(lista.Count() > 0)
                {
                    var entitie = lista.FirstOrDefault();

                    entitie.Name = item.Name;
                    entitie.Identification = item.Identification;
                    entitie.Street = item.Street;
                    entitie.ExteriorNumber = item.ExteriorNumber;
                    entitie.InteriorNumber = item.InteriorNumber;
                    entitie.Suburb = item.Suburb;
                    entitie.Municipality = item.Municipality;
                    entitie.State = item.State;
                    entitie.Country = item.Country;
                    entitie.PostCode = item.PostCode;
                    entitie.ModificationDate = DateTime.Now;

                    result = context.SaveChanges();
                }
            }
            return result;
        }

    }
}
