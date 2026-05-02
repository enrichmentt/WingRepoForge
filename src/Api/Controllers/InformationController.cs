using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Core.Models.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WingRepoForge.Core.Models.Responses;

namespace WingRepoForge.Api.Controllers
{
    [Route("[controller]")]
    public class InformationController : Controller
    {
        private readonly ILogger<InformationController> _logger;

        public InformationController(ILogger<InformationController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/information")]
        public ActionResult<ServerInformationResponse> GetInformation()
        {
            var response = new ServerInformationResponse(
                SourceIdentifier: "WingRepoForge",
                ServerVersion: "1.0.0",
                ProtocolVersion: "1.0.0"
            );

            return Ok(response);
        }

        [HttpGet("/manifestSearch")]
        public ActionResult<ManifestSearchCapabilityResponse> GetSearchCapabilities()
        {
            var response = new ManifestSearchCapabilityResponse(
                SupportedQueryMethods: new[] { "CaseInsensitiveSubstring" }
            );

            return Ok(response);
        }
    }
}
