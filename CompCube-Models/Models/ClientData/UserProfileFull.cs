using Newtonsoft.Json;

namespace CompCube_Models.Models.ClientData;

[method: JsonConstructor]
public class UserProfileFull(
    string username, 
    string platformId, 
    string? beatKhanaId, 
    string avatarUrl, 
    Flair[] flairs, 
    bool banned, 
    DateTime lastPlayed, 
    DateTime joinDate, 
    DateTime lastUpdated,
    CompetitiveInfo[] allCompetitiveData)
{
    [JsonProperty("username")]
    public string Username { get; private set; } = username;

    [JsonProperty("platformId")]
    public string PlatformId { get; private set; } = platformId;
    
    [JsonProperty("beatKhanaId")]
    public string? BeatKhanaId { get; private set; } = beatKhanaId;

    [JsonProperty("avatarUrl")]
    public string AvatarUrl { get; private set; } = avatarUrl;

    [JsonProperty("flair")]
    public Flair[] Flairs { get; private set; } = flairs;

    [JsonProperty("banned")]
    public bool Banned { get; private set; } = banned;
    
    [JsonProperty("competetiveData")]
    public CompetitiveInfo[] AllCompetitiveData { get; private set; } = allCompetitiveData;

    [JsonProperty("lastPlayed")]
    public DateTime LastPlayed { get; private set; } = lastPlayed;
    
    [JsonProperty("lastUpdated")]
    public DateTime LastUpdated { get; private set; } = lastUpdated;
    
    [JsonProperty("joinDate")]
    public DateTime JoinDate { get; private set; } = joinDate;
}