using Tanks.Models;
using Tanks.Services;
using Microsoft.AspNetCore.Mvc;

namespace Tanks.Controllers;

[ApiController]
[Route("[contoller]")]
public class TanksController : ControllerBase
{
    //http action to get all the tanks from our service and to the client
    [HttpGet]
    public ActionResult<List<Tank>> Get() => TankService.GetAll();
}