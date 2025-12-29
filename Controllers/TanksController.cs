using Mix_Calculator.Models;
using Mix_Calculator.Services;
using Microsoft.AspNetCore.Mvc;

namespace Tanks.Controllers;

[ApiController]
[Route("[controller]")]
public class TanksController : ControllerBase
{
    //http action to get all the tanks from our service and to the client
    [HttpGet]
    public ActionResult<List<Tank>> Get() => TankService.GetAll();
}