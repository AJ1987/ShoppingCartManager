using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartCore.Entities.Request
{
    public class ProductRequestDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductShortName { get; set; }
        public string ProductSKU { get; set; }
        public decimal ProductPrice { get; set; }
        public int InventoryQty { get; set; }
        public int DiscountType { get; set; }
        public decimal DiscountValue { get; set; }
    }
}
