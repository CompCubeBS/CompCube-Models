using CompCube_Models.Models.ClientData;
using CompCube_Models.Models.Map;
using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.ServerPackets;

[method: JsonConstructor]
public class MatchCreatedPacket(UserStatistics red, UserStatistics blue, VotingMap[] initialMaps) : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.MatchCreated;

    [JsonProperty("red")]
    public readonly UserStatistics Red = red;

    [JsonProperty("blue")] 
    public readonly UserStatistics Blue = blue;
    
    [JsonProperty("initialMaps")]
    public readonly VotingMap[] InitialMaps = initialMaps;
}