using ShoppingCartCommon;
using ShoppingCartCore.Aggregates;
using ShoppingCartCore.Entities.Request;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ShoppingCartTest
{
    public class PromoProductsUnitTest
    {
        [Fact]
        public void GivenMacBookAndRaspShouldOnlyReturnPiB()
        {
            var mockProducts = new List<ProductRequestDTO>() {
                new ProductRequestDTO
                {
                    ProductId = 1,
                    ProductName = PromoCommon.MacBook,
                    ProductPrice = (decimal)5399.99,
                    DiscountType = 2
                },
                new ProductRequestDTO
                {
                    ProductId = 2,
                    ProductName = PromoCommon.RaspBerry,
                    ProductPrice = (decimal)30.00
                }
            };

            var returnProduct = new PromoProducts();
            var totalPrice = returnProduct.Promotion(mockProducts);
            totalPrice.Equals((decimal)5399.99);
        }

    }
}
