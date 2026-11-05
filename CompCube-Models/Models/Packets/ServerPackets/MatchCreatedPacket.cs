using CompCube_Models.Models.ClientData;
using CompCube_Models.Models.Map;
using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.ServerPackets;

[method: JsonConstructor]
public class MatchCreatedPacket(UserProfile red, UserProfile blue, VotingMap[] initialMaps) : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.MatchCreated;

    [JsonProperty("red")]
    public readonly UserProfile Red = red;

    [JsonProperty("blue")] 
    public readonly UserProfile Blue = blue;
    
    [JsonProperty("initialMaps")]
    public readonly VotingMap[] InitialMaps = initialMaps;
}