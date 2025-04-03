using CicdGeneratorService.Models;
using CicdGeneratorService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CicdGeneratorService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CiCdController : ControllerBase
    {
        private readonly IOpenAiService _openAi;

        public CiCdController(IOpenAiService openAi)
        {
            _openAi = openAi;
        }

        [HttpPost("generate")]
        public async Task<IActionResult> GeneratePipeline([FromBody] CiCdRequest request)
        {
            string prompt = $"Generate a CI/CD pipeline YAML for a {request.Language} project using {request.Platform} to deploy to {request.DeploymentTarget}. " +
                            $"Make it optimized, production-ready, and include build/test/deploy stages.";

            var result = await _openAi.GenerateYamlAsync(prompt);

            return Ok(new { yaml = result });
        }
    }
}
