using CicdGeneratorService.Models;
using CicdGeneratorService.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;

[ApiController]
[Route("api/[controller]")]
public class CiCdController : ControllerBase
{
    private readonly IOpenAiService _openAi;
    private readonly Container _container;

    public CiCdController(IOpenAiService openAi, CosmosClient cosmos)
    {
        _openAi = openAi;
        _container = cosmos.GetContainer("PromptHistoryDB", "Prompts");
    }

    [HttpPost("generate")]
    public async Task<IActionResult> GeneratePipeline([FromBody] CiCdRequest request)
    {
        string prompt = $"Generate a CI/CD pipeline YAML for a {request.Language} project using {request.Platform} to deploy to {request.DeploymentTarget}.";
        string yaml = await _openAi.GenerateYamlAsync(prompt);
        var embedding = await _openAi.GetEmbeddingAsync(prompt);

        var entry = new CiCdPromptEntry
        {
            Username = request.Username,
            OrgId = request.OrgId,
            Project = request.Project,
            Prompt = prompt,
            Yaml = yaml,
            Embedding = embedding
        };

        await _container.CreateItemAsync(entry, new PartitionKey(entry.OrgId));
        return Ok(new { yaml });
    }
}
