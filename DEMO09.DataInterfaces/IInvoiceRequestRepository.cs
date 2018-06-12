using DEMO09.Types;
using System.Collections.Generic;

namespace DEMO09.DataInterfaces
{
    public interface IInvoiceRequestRepository
    {
        IEnumerable<InvoiceRequestType> FindAllInvoiceRequest();

    }
}
