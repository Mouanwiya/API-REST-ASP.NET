using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API_REST_App1_school.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class CouresController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new List<string>() { "c#", "java", "Flutter", "Angular", "Php"};
        }
    }
}
