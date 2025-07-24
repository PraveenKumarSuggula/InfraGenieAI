using System.Net.Http.Headers;
using System.Text.Json;

namespace CicdGeneratorService.Services
{
    public class OpenAiService : IOpenAiService
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
            var body = new
            {
                model = "gpt-3.5-turbo",
                messages = new[]
                {
                new { role = "system", content = "You are a DevOps assistant that generates CI/CD YAML files." },
                new { role = "user", content = prompt }
            }
            };

            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _config["OpenAI:ApiKey"]);
            var response = await _client.PostAsJsonAsync("https://api.openai.com/v1/chat/completions", body);
            var json = await response.Content.ReadFromJsonAsync<JsonElement>();
            return json.GetProperty("choices")[0].GetProperty("message").GetProperty("content").GetString()!;
        }

        public async Task<float[]> GetEmbeddingAsync(string input)
        {
            var body = new { input, model = "text-embedding-3-small" };
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _config["OpenAI:ApiKey"]);
            var response = await _client.PostAsJsonAsync("https://api.openai.com/v1/embeddings", body);
            var json = await response.Content.ReadFromJsonAsync<JsonElement>();
            return json.GetProperty("data")[0].GetProperty("embedding").EnumerateArray().Select(e => e.GetSingle()).ToArray();
        }
    }
}
