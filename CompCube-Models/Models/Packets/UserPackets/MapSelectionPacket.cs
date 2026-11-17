using CompCube_Models.Models.Map;
using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.UserPackets;

[method: JsonConstructor]
public class MapSelectionPacket(CCBeatmapData map) : UserPacket
{
    public override UserPacketTypes PacketType => UserPacketTypes.MapSelection;

    [JsonProperty("map")]
    public readonly CCBeatmapData Selection = map;
}