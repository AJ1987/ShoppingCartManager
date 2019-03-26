using ShoppingCartCore.Entities.Request;
using System;
using System.Collections.Generic;
using System.Text;
using static ShoppingCartCommon.PromoEnums;

namespace ShoppingCartCore.Interfaces.IServices
{
    public interface IPromoCheckoutSerivce
    {
         decimal Promotion(IList<ProductRequestDTO> product);
    }
}
