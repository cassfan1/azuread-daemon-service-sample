using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TeamViewerService.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TeamViewerController : ControllerBase
  {
    [HttpGet]
    [Authorize(Policy = "Policy")]
    public string Get()
    {
      return "Successfully";
    }
  }
}