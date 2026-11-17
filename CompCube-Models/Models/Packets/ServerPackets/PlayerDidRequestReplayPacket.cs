using CompCube_Models.Models.ClientData;
using CompCube_Models.Models.Map;
using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.ServerPackets;

[method: JsonConstructor]
public class PlayerDidRequestReplayPacket(BeatmapData mapToReplay, UserProfile requester) : ServerPacket
{
    [JsonProperty("mapToReplay")]
    public readonly BeatmapData? MapToReplay = mapToReplay;
    
    [JsonProperty("requester")]
    public readonly UserProfile Requester = requester;

    public override ServerPacketTypes PacketType => ServerPacketTypes.PlayerDidRequestReplay;
}