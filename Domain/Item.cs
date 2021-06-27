using System;

namespace Domain
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Unit { get; set; }
        public string ItemDescription { get; set; }
        public decimal UnitPrice { get; set; }
        public string Catalog { get; set; }
    }
}
