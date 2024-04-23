using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace scamp.Controllers.Api

{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaAController : ControllerBase
    {
        [HttpGet]
        public ActionResult Index()
        {
            return Ok("olá turma A");
        }

	}
}
