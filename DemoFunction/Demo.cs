using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System.Net;

namespace DemoFunction
{
    public class Demo
    {
        private readonly ILogger<Demo> _logger;

        public Demo(ILogger<Demo> logger)
        {
            _logger = logger;
        }

        [Function("Demo")]
        public <HttpResponseData Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get")] 
            HttpRequestData req)
        {
            //_logger.LogInformation("Started the GetGuid Function Call");

            var response = req.CreateResponse(HttpStatusCode.OK);

            return response;
        }
    }
}
