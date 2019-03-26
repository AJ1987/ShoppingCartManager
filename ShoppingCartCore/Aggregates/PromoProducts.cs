using ShoppingCartCommon;
using ShoppingCartCore.Abstracts;
using ShoppingCartCore.Entities.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartCore.Aggregates
{
    public class PromoProducts : PromoStrategy
    {
        public override decimal Promotion(IList<ProductRequestDTO> products)
        {
            var reashberry = PromoCommon.RaspBerry;
            decimal totalPrice = 0;
            for (int i = 0; i < products.Count ; i++)
            {
                var product = products[i];

                //Depends on:  one Mac with one Rashberry.
                //If not, this logic need to change
                if (product.ProductName.Contains(reashberry))
                    continue;
                totalPrice += product.ProductPrice;
            }
            return totalPrice;
        }
    }
}
