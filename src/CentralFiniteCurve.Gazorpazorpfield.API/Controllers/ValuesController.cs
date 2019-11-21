using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CentralFiniteCurve.Gazorpazorpfield.API.Controllers
{
    /// <summary>
    /// A sample controller for reference.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger<ValuesController> _logger;

        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            string message = $"Method {System.Reflection.MethodBase.GetCurrentMethod().Name} called";
            _logger.LogDebug(message);
            return message;
        }

        /// <summary>
        /// Echoes the received ID.
        /// </summary>
        /// <remarks>
        /// Remarks element can be used to create this type of method documentation for Swagger UI.
        /// This supplements information specified in the summary element and provides a more robust Swagger UI.
        /// </remarks>
        /// <param name="id">The ID in the request.</param>
        /// <returns>A message with the received ID.</returns>
        /// <response code="200">Returns a message with the received ID.</response>
        [HttpGet("{id}")] // <Root URI>/api/values/<id>
        [Produces("text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<string> Get(int id)
        {
            string message = $"Method {System.Reflection.MethodBase.GetCurrentMethod().Name} called with ID {id}";
            _logger.LogDebug(message);
            return message;
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
            _logger.LogDebug($"Method {System.Reflection.MethodBase.GetCurrentMethod().Name} called with value: {value}");
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            _logger.LogDebug($"Method {System.Reflection.MethodBase.GetCurrentMethod().Name} called with ID {id} and value: {value}");
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _logger.LogDebug($"Method {System.Reflection.MethodBase.GetCurrentMethod().Name} called with ID {id}");
        }
    }
}
