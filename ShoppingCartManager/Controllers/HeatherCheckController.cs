using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ShoppingCartManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeatherCheckController : ControllerBase
    {       
        // GET api/values/5
        [HttpGet("test")]
        public ActionResult<bool> Get()
        {
            return true;
        }         
    }
}
