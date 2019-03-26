using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartCore.Entities.DO
{
    public class Promotion
    {
        public int PromoId { get; set; }
        public int ProductId { get; set; }
        public string PromoCode { get; set; }
        public string PromoName { get; set; }
        public int DiscountType { get; set; }
        public decimal DiscountValue { get; set; }
    }
}
