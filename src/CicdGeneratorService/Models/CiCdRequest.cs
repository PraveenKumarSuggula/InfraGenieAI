namespace CicdGeneratorService.Models
{
    public class CiCdRequest
    {
        public string Language { get; set; } = string.Empty;
        public string Platform { get; set; } = string.Empty;
        public string DeploymentTarget { get; set; } = string.Empty;

        // New metadata
        public string Username { get; set; } = string.Empty;
        public string Project { get; set; } = string.Empty;
        public string OrgId { get; set; } = string.Empty;
    }
}
