using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace ProductAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public ActionResult<string>Get()=>
            Ok("Hello, Mario. The Princes is in another castle");  
    }
}
