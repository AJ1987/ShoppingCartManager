using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartCore.Entities.Request;
using ShoppingCartCore.Interfaces.IServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoppingCartManager.Controllers
{
    [Route("api/[controller]")]
    public class CheckoutController : Controller
    {
        private IPromoCheckoutSerivce _promoCheckoutSerivce;
        public CheckoutController(IPromoCheckoutSerivce promoCheckoutSerivce)
        {
            _promoCheckoutSerivce = promoCheckoutSerivce;
        }
                                                 
        [HttpPost("promo")]
        public IActionResult Post([FromBody]IList<ProductRequestDTO> request)
        {
            if(request == null)
            {
                return BadRequest("request shouldn't be null");
            }
            return Ok(_promoCheckoutSerivce.Promotion(request));
        }
    }
}
