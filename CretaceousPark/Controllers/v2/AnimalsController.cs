using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Versioning;
using CretaceousPark.Models;

namespace CretaceousPark.Solution.Controllers.v2
{
  [ApiVersion("2.0")]
  [Route("api/v{version:apiVersion}/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    // private readonly CretaceousParkContext _context;

    // public AnimalsController(CretaceousParkContext context)
    // {
    //     _context = context;
    // }
    
    [HttpGet("Version 2")]
    public IActionResult Get()
    {
      return new OkObjectResult("this is from v2 controller");
    }
    
      
 }
}