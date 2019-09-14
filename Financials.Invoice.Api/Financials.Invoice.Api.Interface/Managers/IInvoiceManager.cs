using Financials.Invoice.Api.Models.InvoiceModels;

namespace Financials.Invoice.Api.Interfaces.Managers
{
    public interface IInvoiceManager
    {
        void CreateInvoice(InvoiceModel invoice);
        InvoiceModel ReadInvoiceByID(long InvoiceId);
        InvoiceModel UpdateInvoiceByID(long InvoiceId);
        void DeleteInvoiceByID(long InvoiceId);
    }
}
