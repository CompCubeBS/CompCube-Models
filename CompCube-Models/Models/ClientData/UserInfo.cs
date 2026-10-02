using Newtonsoft.Json;

namespace CompCube_Models.Models.ClientData;

[method: JsonConstructor]
public class UserInfo(string username, string platformId, string? beatKhanaId, string avatarUrl, Flair? flair, bool banned)
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
    public Flair? Flair { get; private set; } = flair;

    [JsonProperty("banned")]
    public bool Banned { get; private set; } = banned;
}