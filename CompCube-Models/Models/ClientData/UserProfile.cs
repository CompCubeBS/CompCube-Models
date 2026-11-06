using Newtonsoft.Json;

namespace CompCube_Models.Models.ClientData;

[method: JsonConstructor]
public class UserProfile(
    string guid,
    string userName, 
    string platformId, 
    string avatarUrl, 
    bool banned,
    Flair[] flairs, 
    CompetitiveInfo competitiveStats)
{
    [JsonProperty("guid")]
    public string Guid { get; } = guid;
    
    [JsonProperty("userName")]
    public string UserName { get; } = userName;
    
    [JsonProperty("banned")]
    public bool Banned { get; } = banned;
    
    [JsonProperty("platformId")]
    public string PlatformId { get; } = platformId;
    
    [JsonProperty("avatarUrl")]
    public string AvatarUrl { get; } = avatarUrl;
    
    [JsonProperty("flairs")]
    public Flair[] Flairs { get; } = flairs;

    [JsonProperty("competitiveStats")]
    public CompetitiveInfo CompetitiveStats = competitiveStats;
}