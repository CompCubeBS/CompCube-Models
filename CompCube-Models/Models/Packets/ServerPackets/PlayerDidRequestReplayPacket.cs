using CompCube_Models.Models.Map;
using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.ServerPackets;

[method: JsonConstructor]
public class PlayerDidRequestReplayPacket(VotingMap mapToReplay)
{
    [JsonProperty("mapToReplay")]
    public readonly VotingMap MapToReplay = mapToReplay;
}