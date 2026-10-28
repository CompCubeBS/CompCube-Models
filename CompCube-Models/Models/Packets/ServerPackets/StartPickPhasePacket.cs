using CompCube_Models.Models.Map;
using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.ServerPackets;

[method: JsonConstructor]
public class StartPickPhasePacket(VotingMap[] availableMaps, bool isOwnPick, float multiplier, float redHealth, float blueHealth) : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.StartPickPhase;

    [JsonProperty("availablePicks")]
    public readonly VotingMap[] AvailableMaps = availableMaps;

    [JsonProperty("isOwnPick")]
    public readonly bool IsOwnPick = isOwnPick;

    [JsonProperty("multiplier")] 
    public readonly float Multiplier = multiplier;
    
    [JsonProperty("redHealth")]
    public readonly float RedHealth = redHealth;
    
    [JsonProperty("blueHealth")]
    public readonly float BlueHealth = blueHealth;
}