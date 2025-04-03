using System.Net.Http.Headers;
using System.Text.Json;

namespace CicdGeneratorService.Services
{
    public class OpenAiService: IOpenAiService
    {
        private readonly HttpClient _client;
        private readonly IConfiguration _config;

        public OpenAiService(HttpClient client, IConfiguration config)
        {
            _client = client;
            _config = config;
        }

        public async Task<string> GenerateYamlAsync(string prompt)
        {
            var apiKey = _config["OpenAI:ApiKey"];
            _client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", apiKey);

            var body = new
            {
                model = "gpt-3.5-turbo",
                messages = new[]
                {
                new { role = "system", content = "You are a DevOps assistant that generates CI/CD YAML files." },
                new { role = "user", content = prompt }
            }
            };

            var response = await _client.PostAsJsonAsync("https://api.openai.com/v1/chat/completions", body);
            var result = await response.Content.ReadFromJsonAsync<JsonElement>();
            return result.GetProperty("choices")[0].GetProperty("message").GetProperty("content").GetString()!;
        }
    }
}
