using API.Model;
using API.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarriffController : ControllerBase
    {
        public readonly IProductGeneratorService _service;
        public TarriffController(IProductGeneratorService service)
        {
            _service = service; 
        }

        [HttpGet("{consumption}")]
        public List<Product> GetProducts(long consumption)
        {
            return  _service.GetProducts(consumption);

        }

    }
}
