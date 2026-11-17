using CompCube_Models.Models.Map;
using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.UserPackets;

public class DiscardMapsPacket(CCBeatmapData[] maps) : UserPacket
{
    public override UserPacketTypes PacketType => UserPacketTypes.DiscardMaps;
    
    [JsonProperty("maps")]
    public readonly CCBeatmapData[] Maps = maps;
}