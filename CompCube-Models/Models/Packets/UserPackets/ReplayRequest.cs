using Newtonsoft.Json;

namespace CompCube_Server.Models.CompCube_Models.Models.Packets.UserPackets;

[method: JsonConstructor]
public class ReplayRequest(bool wantsToReplay)
{
    [JsonProperty("wantsToReplay")] 
    public readonly bool WantsToReplay = wantsToReplay;
}