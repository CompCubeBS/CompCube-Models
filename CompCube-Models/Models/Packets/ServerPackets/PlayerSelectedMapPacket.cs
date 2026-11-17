using CompCube_Models.Models.Map;
using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.ServerPackets;

[method: JsonConstructor]
public class PlayerSelectedMapPacket(CCBeatmapData map) : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.PlayerSelectedMap;

    public readonly CCBeatmapData Map = map;
}