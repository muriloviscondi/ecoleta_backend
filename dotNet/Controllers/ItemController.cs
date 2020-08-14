using System.Collections.Generic;
using System.Threading.Tasks;
using dotNet.Data;
using dotNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotNet.Controllers
{
  [ApiController]
  [Route("items")]
  public class ItemController : ControllerBase
  {
    [HttpGet]
    [Route("")]
    public async Task<ActionResult<List<Item>>>
    Get([FromServices] DataContext context)
    {
      var items = await context.Items.ToListAsync();
      return items;
    }

    [HttpPost]
    [Route("")]
    public async Task<ActionResult<Item>>
    Post([FromServices] DataContext context, [FromBody] Item model)
    {
      if (ModelState.IsValid)
      {
        context.Items.Add(model);
        await context.SaveChangesAsync();
        return model;
      }
      else
      {
        return BadRequest(ModelState);
      }
    }
  }
}