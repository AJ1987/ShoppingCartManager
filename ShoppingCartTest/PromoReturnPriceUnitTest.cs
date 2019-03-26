using ShoppingCartCommon;
using ShoppingCartCore.Aggregates;
using ShoppingCartCore.Entities.Request;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ShoppingCartTest
{
    public class PromoReturnPriceUnitTest
    {
        [Fact]
        public void GivenThreeGoogleHomeShouldReturnTwoTotalPrice()
        {
            var mockProducts = new List<ProductRequestDTO>() {
                new ProductRequestDTO
                {
                    ProductId = 1,
                    ProductName = PromoCommon.GoogleHome,
                    ProductPrice = (decimal)49.99,
                    DiscountType = 1
                },
                new ProductRequestDTO
                {
                    ProductId = 2,
                    ProductName = PromoCommon.GoogleHome,
                    ProductPrice = (decimal)49.99,
                    DiscountType = 1
                },
                 new ProductRequestDTO
                 {
                     ProductId = 3,
                     ProductName = PromoCommon.GoogleHome,
                     ProductPrice = (decimal)49.99,
                     DiscountType = 1
                 }
            };

            var returnPrice = new PromoPrice();
            var totalPrice = returnPrice.Promotion(mockProducts);
            totalPrice.Equals((decimal)99.98);
        }

    }
}
