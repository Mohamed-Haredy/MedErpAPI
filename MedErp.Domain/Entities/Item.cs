using MedErp.Domain.Base;

namespace MedErp.Domain.Entities
{
    public class Item : Entity,IAggregateRoot
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Rank { get; set; }
        public string? Description { get; set; }
        public long? TypeId { get; set; }
        public string? CrossReference { get; set; }
        public string? ReorderPoint { get; set; }
        public float? SalePriceperUnit { get; set; }
        public string? DistributionUnit  { get; set; }
        public DateTime? DateReceived  { get; set; }
        public int? InvoiceNumber  { get; set; }
        public int? Quantity { get; set; }
        public int? Unit { get; set; }
        public float? PurchaseCost  { get; set; }
        public int? SerialNumber { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public long? VendorId { get; set; }
        public long? AisleId { get; set; }
        public bool? GiftinKind { get; set; }









        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return Id;
        }
    }
}
