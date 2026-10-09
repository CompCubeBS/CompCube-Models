using Newtonsoft.Json;

namespace CompCube.Models.CompCube_Models.Models.Auth;

public sealed class AuthResponse
{
    [JsonProperty("token")] public string Token { get; set; } = string.Empty;
    [JsonProperty("platform")] public string Platform { get; set; } = string.Empty;
    [JsonProperty("platformId")] public string PlatformId { get; set; } = string.Empty;
    [JsonProperty("userGuid")] public string? UserGuid { get; set; }
    [JsonProperty("discordId")] public string? DiscordId { get; set; }
}