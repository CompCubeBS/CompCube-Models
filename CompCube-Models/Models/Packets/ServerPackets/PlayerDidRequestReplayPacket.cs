using CompCube_Models.Models.ClientData;
using CompCube_Models.Models.Map;
using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.ServerPackets;

[method: JsonConstructor]
public class PlayerDidRequestReplayPacket(VotingMap mapToReplay, UserStatistics requester) : ServerPacket
{
    [JsonProperty("mapToReplay")]
    public readonly VotingMap? MapToReplay = mapToReplay;
    
    [JsonProperty("requester")]
    public readonly UserStatistics Requester = requester;

    public override ServerPacketTypes PacketType => ServerPacketTypes.PlayerDidRequestReplay;
}