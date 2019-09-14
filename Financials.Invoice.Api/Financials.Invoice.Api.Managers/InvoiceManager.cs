using Financials.Invoice.Api.Interfaces.Managers;
using Financials.Invoice.Api.Models.InvoiceModels;

namespace Financials.Invoice.Api.Managers
{
    public class InvoiceManager : IInvoiceManager
    {
        public void CreateInvoice(InvoiceModel invoice)
        {

        }

        public void DeleteInvoiceByID(long InvoiceId)
        {
            throw new System.NotImplementedException();
        }

        public InvoiceModel ReadInvoiceByID(long InvoiceId)
        {
            throw new System.NotImplementedException();
        }

        public InvoiceModel UpdateInvoiceByID(long InvoiceId)
        {
            throw new System.NotImplementedException();
        }
    }
}
