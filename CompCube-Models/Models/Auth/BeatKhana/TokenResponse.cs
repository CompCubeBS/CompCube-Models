using Newtonsoft.Json;

namespace CompCube_Server.Models.CompCube_Models.Models.Auth.BeatKhana;


public class TokenResponse(string token, string tokenType, float expiresIn, string refreshToken, string scope)
{
    [JsonProperty("access_token")]
    public readonly string AccessToken = token;
    
    [JsonProperty("token_type")]
    public readonly string TokenType = tokenType;
    
    [JsonProperty("expires_in")]
    public readonly float ExpiresIn = expiresIn;
    
    [JsonProperty("refresh_token")]
    public readonly string RefreshToken = refreshToken;
    
    [JsonProperty("scope")]
    public readonly string Scope = scope;
}