using System;

namespace Domain
{
    public class PurchaseList
    {
        public Guid Id { get; set; }
        public string PurchaseOrderId { get; set; }
        public string ItemId { get; set; }
        public int Quantity { get; set; }
        public decimal Subtotal { get; set; }
    }
}