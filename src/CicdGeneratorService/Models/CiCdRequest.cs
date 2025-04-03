namespace CicdGeneratorService.Models
{
    public class CiCdRequest
    {
        public string Language { get; set; } = string.Empty;
        public string Platform { get; set; } = string.Empty;
        public string DeploymentTarget { get; set; } = string.Empty;
    }
}
