
using System;
using System.Collections.Generic;
using DEMO09.BusinessInterfaces;
using DEMO09.DataInterfaces;
using DEMO09.Types;

namespace DEMO09.BusinessLayer
{
    public class InvoiceRequestProcessor : IInvoiceRequestProcessor
    {
        private readonly IInvoiceRequestRepository _repository;

        public InvoiceRequestProcessor(IInvoiceRequestRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<InvoiceRequestType> FindAllInvoiceRequest()
        {
            return _repository.FindAllInvoiceRequest();
        }
    }
}
