using CompCube_Models.Models.Map;

namespace CompCube_Models.Models.Packets.ServerPackets;

public class UpdateCardsPacket(CCBeatmapData[] maps) : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.UpdateCards;
    
    public readonly CCBeatmapData[] Maps = maps;
}