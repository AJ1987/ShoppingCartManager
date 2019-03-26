using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartCore.Entities.DO
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductShortName { get; set; }
        public string ProductSKU { get; set; }
        public decimal ProductPrice { get; set; }
        public int ImageId { get; set; }
    }
}
