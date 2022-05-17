using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleInterestApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SimpleInterestController : ControllerBase
    {
        [HttpGet]
        public int InterestAmnt(int p, int r, int n)
        {
            return p * n * r / 100;
        }

    }
}
