using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_diff.Controllers
{
  [Route("v1/[controller]")]
  [ApiController]
  public class DiffController : ControllerBase
  {
    // POST v1/diff/{id}/left
    [HttpPost("{id}/left")]
    public ActionResult<string> DiffLeft(int id, [FromBody] string value)
    {
      return "ok";
    }

    // POST v1/diff/{id}/right
    [HttpPost("{id}/right")]
    public ActionResult<string> DiffRight(int id, [FromBody] string value)
    {
      return "ok";
    }

    // GET v1/diff/{id}
    [HttpGet("{id}")]
    public ActionResult<string> DiffResult(int id)
    {
      return "diff result";
    }

  }
}
