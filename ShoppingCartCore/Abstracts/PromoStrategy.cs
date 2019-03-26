using ShoppingCartCore.Entities.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartCore.Abstracts
{
    public abstract class PromoStrategy
    {
        public abstract decimal Promotion(IList<ProductRequestDTO> products);
    }
}
