using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Financials.Invoice.Api.Models.InvoiceModels
{
    public class InvoiceModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public long InvoiceID { get; set; }
        public BsonDateTime CreatedDateTime { get; set; }
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }
        public string SourceCurrency { get; set; }
        public string PartyCode { get; set; }
    }
}
