using Microsoft.AspNetCore.Mvc;

namespace JsonRevert.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RevertController : ControllerBase
    {
       // POST api/revert
        [HttpPost]
        public void Post([FromBody] string json)
        {
        }
    }
}