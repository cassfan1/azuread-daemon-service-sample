using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TeamViewerService.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class WeatherForecastController : ControllerBase
  {
    [Authorize(Policy = "Policy1")]
    [HttpGet]
    public string Get()
    {
      return "Successfully";
    }
  }
}
