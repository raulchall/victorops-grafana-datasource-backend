using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Serilog;
using VictorOpsBackendApi.Models;
using Newtonsoft.Json;

namespace VictorOpsBackendApi.Controllers
{
    [ApiController]
    public class VictorOpsGrafanaDatasourceController : ControllerBase
    {
        private readonly ILogger<VictorOpsGrafanaDatasourceController> _logger;

        private ICollection<TagKey> _tagKeys;
        private ICollection<TagValue> _countryTagValues;

        public VictorOpsGrafanaDatasourceController(ILogger<VictorOpsGrafanaDatasourceController> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _tagKeys = new List<TagKey>() {
                new TagKey() { type = "string", text = "Country"}
            };
            _countryTagValues = new List<TagValue>() {
                new TagValue() { text = "SE"},
                new TagValue() { text = "DE"},
                new TagValue() { text = "US"}
            };
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult> Get()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(100));
            return Ok("VictorOps backend is OK");
        }

        [HttpPost]
        [Route("query")]
        public async Task<ActionResult<TableQueryResponse>> Query([FromBody] QueryRequest request)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(100));
            var requestJson = JsonConvert.SerializeObject(request);
            _logger.LogInformation(requestJson);
            var response = new TableQueryResponse();
            return Ok(response);
        }

        [HttpPost]
        [Route("annotations")]
        public async Task<ActionResult<AnnotationResponse>> Annotations([FromBody] AnnotationRequest request)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(100));
            var requestJson = JsonConvert.SerializeObject(request);
            _logger.LogInformation(requestJson);
            var response = new AnnotationResponse();
            return Ok(response);
        }

        [HttpPost]
        [Route("search")]
        public async Task<ActionResult<ICollection<string>>> Search([FromBody] QueryRequest request)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(100));
            var requestJson = JsonConvert.SerializeObject(request);
            _logger.LogInformation(requestJson);

            var response = new List<string>() { "metric1", "metrics2", "metric3", "avg", "teams", "users"};
            return Ok(response);
        }

        [HttpPost]
        [Route("tag-keys")]
        public async Task<ActionResult> GetTagKeys()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(100));
            return Ok(_tagKeys);
        }

        [HttpPost]
        [Route("tag-values")]
        public async Task<ActionResult> GetTagValues()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(100));
            return Ok(_countryTagValues);
        }
    }
}
