using System;
using Microsoft.AspNetCore.Mvc;

namespace CentralFiniteCurve.Gazorpazorpfield.API.Controllers
{
    /// <summary>
    /// This class provides health and readiness check API used to monitor the status of the microservice.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController : ControllerBase
    {
        private readonly string[] Responses =
        {
            "I'm alive",
            "Oh I, oh, I'm still alive",
            "Hey, hey, I, oh, I'm still alive",
            "Hey I, oh, I'm still alive, yeah oh"
        };

        private static int _counter = 0;

        [HttpGet]
        public ActionResult<string> Get()
        {
            string response = Responses[_counter++];

            if (_counter > Responses.Length - 1)
            {
                _counter = 1;
            }

            return Ok(response);
        }
    }
}
