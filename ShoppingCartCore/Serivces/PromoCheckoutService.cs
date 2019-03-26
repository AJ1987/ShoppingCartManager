using ShoppingCartCommon;
using ShoppingCartCore.Aggregates;
using ShoppingCartCore.Entities.Request;
using ShoppingCartCore.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Text;
using static ShoppingCartCommon.PromoEnums;

namespace ShoppingCartCore.Serivces
{
    public class PromoCheckoutService : IPromoCheckoutSerivce
    {                
        public decimal Promotion(IList<ProductRequestDTO> products)
        {
            if(products ==null)
            {
                throw new ArgumentNullException("products shouldn't be null");
            }
            //just suppose this first one is the default product, not the finnally code
            var product = products[0];
            PromoContext promo = new PromoContext((PromoType)product.DiscountType);
            return promo.ContextInterface(products);
        }
    }
}
