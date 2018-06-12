using DEMO09.Types;
using System.Collections.Generic;

namespace DEMO09.BusinessInterfaces
{
    public interface IInvoiceRequestProcessor
    {
        IEnumerable<InvoiceRequestType> FindAllInvoiceRequest();
    }
}
