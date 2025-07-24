public class CiCdPromptEntry
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Username { get; set; } = string.Empty;
    public string Project { get; set; } = string.Empty;
    public string OrgId { get; set; } = string.Empty;
    public string Type { get; set; } = "cicd";
    public string Prompt { get; set; } = string.Empty;
    public string Yaml { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public float[] Embedding { get; set; } = Array.Empty<float>();
}
