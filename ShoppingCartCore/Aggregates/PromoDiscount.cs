using ShoppingCartCore.Abstracts;
using ShoppingCartCore.Entities.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartCore.Aggregates
{
    public class PromoDiscount : PromoStrategy
    {
        public override decimal Promotion(IList<ProductRequestDTO> products)
        {
            decimal totalPrice = 0;
            for(int i=0; i<products.Count; i++)
            {
                var product = products[i];
                totalPrice += product.ProductPrice * (decimal)0.9;
            }
            return totalPrice;
        }
    }
}
