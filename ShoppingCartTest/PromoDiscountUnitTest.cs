using ShoppingCartCommon;
using ShoppingCartCore.Aggregates;
using ShoppingCartCore.Entities.Request;
using System;
using System.Collections.Generic;
using Xunit;

namespace ShoppingCartTest
{
    public class PromoDiscountUnitTest
    {
        [Fact]
        public void GivenThreeAlexaShouldReturn10PercentDiscount()
        {
            var mockProducts = new List<ProductRequestDTO>() {
                new ProductRequestDTO
                {
                    ProductId = 1,
                    ProductName = PromoCommon.AlexaSpeaker,
                    ProductPrice = (decimal)109.50,
                    DiscountType = 0
                },
                new ProductRequestDTO
                {
                    ProductId = 2,
                    ProductName = PromoCommon.AlexaSpeaker,
                    ProductPrice = (decimal)109.50,
                    DiscountType = 0
                },
                 new ProductRequestDTO
                 {
                     ProductId = 3,
                     ProductName = PromoCommon.AlexaSpeaker,
                     ProductPrice = (decimal)109.50,
                     DiscountType = 0
                 }
            };

            var discount = new PromoDiscount();
            var totalPrice = discount.Promotion(mockProducts);
            totalPrice.Equals((decimal)295.65);
        }
    }
}
