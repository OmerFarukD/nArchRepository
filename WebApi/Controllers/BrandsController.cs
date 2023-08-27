using Application.Features.Brands.Commands.Create;
using Application.Features.Brands.Queries.GetList;
using Core.Application.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class BrandsController : BaseController
{
    
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateBrandCommand brandCommand)
    {
      var data =  await Mediator.Send(brandCommand);
      return Ok(data);
    }

    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListBrandQuery query = new() { PageRequest = pageRequest };

        var data = await Mediator.Send(query);
        return Ok(data);
    }
}