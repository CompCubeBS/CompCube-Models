using Newtonsoft.Json;

namespace CompCube_Models.Models.Server;

public class ServerStatus(
    string[] allowedModVersions,
    ServerState.State state)
{
    [JsonProperty("allowedModVersions")]
    public readonly string[] AllowedModVersions = allowedModVersions;
    
    [JsonProperty("state")]
    public readonly ServerState.State State = state;
}