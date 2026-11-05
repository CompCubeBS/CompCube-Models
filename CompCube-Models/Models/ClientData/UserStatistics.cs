using Newtonsoft.Json;

namespace CompCube_Models.Models.ClientData;

[method: JsonConstructor]
public class UserStatistics(
    string userName, 
    string platformId, 
    string avatarUrl, 
    Flair[] flairs, 
    CompetitiveInfo competitiveStats)
{
    [JsonProperty("userName")]
    public string UserName { get; } = userName;
    
    [JsonProperty("platformId")]
    public string PlatformId { get; } = platformId;
    
    [JsonProperty("avatarUrl")]
    public string AvatarUrl { get; } = avatarUrl;
    
    [JsonProperty("flairs")]
    public Flair[] Flairs { get; } = flairs;

    [JsonProperty("competitiveStats")]
    public CompetitiveInfo CompetitiveStats = competitiveStats;
}