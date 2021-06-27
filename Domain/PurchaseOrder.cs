using System;

namespace Domain
{
    public class PurchaseOrder
    {
        public Guid Id { get; set; }
        public string City { get; set; }
        public string Receiver { get; set; }
        public string WarehouseId { get; set; }
        public string Expedition { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public DateTime OrderDate { get; set; }
        public string Department { get; set; }
        public decimal GrandTotal { get; set; }
    }
}