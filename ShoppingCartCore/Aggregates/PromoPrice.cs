using ShoppingCartCore.Abstracts;
using ShoppingCartCore.Entities.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartCore.Aggregates
{
    public class PromoPrice : PromoStrategy
    {
        public override decimal Promotion(IList<ProductRequestDTO> products)
        {
            decimal totalPrice = 0;
            for (int i = 0; i < products.Count-1; i++)
            {
                var product = products[i];
                totalPrice += product.ProductPrice;
            }
            return totalPrice;
        }
    }
}
