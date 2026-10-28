using CompCube_Models.Models.Packets;
using Newtonsoft.Json;

namespace CompCube_Server.Models.CompCube_Models.Models.Packets.UserPackets;

[method: JsonConstructor]
public class ReplayRequestPacket(bool wantsToReplay) : UserPacket
{
    [JsonProperty("wantsToReplay")] 
    public readonly bool WantsToReplay = wantsToReplay;

    public override UserPacketTypes PacketType => UserPacketTypes.ReplayRequest;
}