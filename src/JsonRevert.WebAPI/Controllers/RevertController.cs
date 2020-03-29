using JsonRevert.WebAPI.BusinessLogic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace JsonRevert.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RevertController : ControllerBase
    {
        private readonly IJsonReverter _jsonReverter;
        
        public RevertController(IJsonReverter jsonReverter)
        {
            _jsonReverter = jsonReverter;
        }
        
       // POST api/revert
        [HttpPost]
        public IActionResult Post([FromBody] string json)
        {
            var result = _jsonReverter.RevertJson(json);
            return Ok(result);
        }
    }
}