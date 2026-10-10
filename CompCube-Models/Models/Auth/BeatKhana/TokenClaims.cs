using Newtonsoft.Json;

namespace CompCube_Server.Models.CompCube_Models.Models.Auth.BeatKhana;

[method: JsonConstructor]
public class TokenClaims(
    string? guid, 
    string? id, 
    string? discordId, 
    string username, 
    string? avatarUrl,
    string? globalName,
    string? platform,
    string? platformId,
    string[]? platformsIds,
    string? tokenType,
    string[] scopes,
    string? scope,
    long? iat,
    long? exp,
    long? nbf)
{
    public readonly string? Guid = guid;
    public readonly string? Id = id;
    public readonly string? DiscordId = discordId;
    public readonly string Username = username;
    public readonly string? AvatarUrl = avatarUrl;
    [JsonProperty("global_name")]
    public readonly string? GlobalName = globalName;
    public readonly string? Platform = platform;
    public readonly string? PlatformId = platformId;
    public readonly string[]? PlatformsIds = platformsIds;
    public readonly string? TokenType = tokenType;
    public readonly string[] Scopes = scopes;
    public readonly string? Scope = scope;
    public readonly long? Iat = iat;
    public readonly int Exp = exp;
    public readonly int? Nbf = nbf;
}