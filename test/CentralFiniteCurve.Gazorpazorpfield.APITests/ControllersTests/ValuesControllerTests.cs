using CentralFiniteCurve.Gazorpazorpfield.API.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace CentralFiniteCurve.Gazorpazorpfield.ApiTests.ControllersTests
{
    public class ValuesControllerTests
    {
        [Fact]
        public void ValuesController_Get_EchoGivenId()
        {
            Mock<ILogger<ValuesController>> mockLogger = new Mock<ILogger<ValuesController>>();
            ValuesController valuesController = new ValuesController(mockLogger.Object);
            ActionResult<string> response = valuesController.Get(42);
            Assert.Equal("Method Get called with ID 42", response.Value);
        }
    }
}
