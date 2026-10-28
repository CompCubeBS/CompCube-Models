using CompCube_Models.Models.ClientData;
using CompCube_Models.Models.Match;
using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.ServerPackets;

[method: JsonConstructor]
public class RoundResultsPacket(Score redScore, Score blueScore) : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.RoundResults;

    [JsonProperty("redScore")] public readonly Score RedScore = redScore;
    
    [JsonProperty("blueScore")] public readonly Score BlueScore = blueScore;
}