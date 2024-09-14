using FastResults.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace UseMultiTenant.Presentation.Controllers;

[Route("[controller]")]
public class HomeController : BaseController
{
    [HttpGet]
    public ActionResult<string> Get()
    {
        return Ok("Está tudo ok!");
    }
}