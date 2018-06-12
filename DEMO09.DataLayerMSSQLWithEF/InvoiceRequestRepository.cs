
using System;
using System.Collections.Generic;
using DEMO09.DataInterfaces;
using DEMO09.Types;
using System.Linq;

namespace DEMO09.DataLayerMSSQLWithEF
{
    public class InvoiceRequestRepository : IInvoiceRequestRepository
    {
        private readonly string _stringconn;

        public InvoiceRequestRepository()
        {
            _stringconn = System.Configuration.ConfigurationManager.ConnectionStrings["AgileInvoice"].ConnectionString;
        }

        public IEnumerable<InvoiceRequestType> FindAllInvoiceRequest()
        {
            List<InvoiceRequestType> result=null;
            using (var context = new AgileInvoiceDbContext(_stringconn))
            {
                IQueryable<InvoiceRequest> lista = null;
                lista = from row in context.InvoiceRequests
                        select row;
                if(lista.Count() > 0)
                {
                    result = new List<InvoiceRequestType>();
                    InvoiceRequestType item = null;
                    foreach(var row in lista)
                    {
                        item = new InvoiceRequestType();
                        item.IdSender = row.IdSender;
                        item.FolioNumber = row.FolioNumber;
                        item.IdUser = row.IdUser;
                        result.Add(item);
                    }
                }
            }

            return result;
        }
    }
}
