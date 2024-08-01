using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace escale.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class GetinformController : ControllerBase
  {
    private readonly dbEntities _context;

    public GetinformController(dbEntities context)
    {
      _context = context;
    }

    [HttpGet]
    public IEnumerable<object> Get([FromQuery] string UserNo)
    {
      var result = from a in _context.ScaleData
                   where a.UserNo == UserNo
                   select new
                   {
                     a.RecordDate,
                     a.Grains,
                     a.Protein,
                     a.Dairy,
                     a.Vegetables,
                     a.Fruits,
                     a.OilsNuts

                   };

      return result;
    }



  }
}
