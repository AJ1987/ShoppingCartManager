using ShoppingCartCore.Abstracts;
using ShoppingCartCore.Entities.Request;
using System;
using System.Collections.Generic;
using System.Text;
using static ShoppingCartCommon.PromoEnums;

namespace ShoppingCartCore.Aggregates
{
    class PromoContext
    {
        PromoStrategy promoStrategy;
        public PromoContext(PromoType promoType)
        {
            //consider using reflect
            switch (promoType)
            {
                case PromoType.Discount:
                    var discount = new PromoDiscount();
                    promoStrategy = discount;
                    break; 
                case PromoType.ReturnPrice:
                    var returnPrice = new PromoPrice();
                    promoStrategy = returnPrice;
                    break;
                case PromoType.ReturnProduct:
                    var returnProduct = new PromoProducts();
                    promoStrategy = returnProduct;
                    break;
                default:
                    break;
            }                 
        }

        //call  promotion according to the strategy object
        public decimal ContextInterface(IList<ProductRequestDTO> products)
        {
            return promoStrategy.Promotion(products);
        }
    }
}
