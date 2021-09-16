using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestAPI.Models;

namespace TestAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class apiController : ControllerBase
    {

        private readonly ILogger<apiController> _logger;

        public apiController(ILogger<apiController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Registration Get()
        {
            return new Registration();
        }
        
    }
}