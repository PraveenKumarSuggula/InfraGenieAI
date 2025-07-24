namespace CicdGeneratorService.Services
{
    public interface IOpenAiService
    {
        Task<string> GenerateYamlAsync(string prompt);
        Task<float[]> GetEmbeddingAsync(string input);
    }
}
