using CompCube_Models.Models.Map;

namespace CompCube_Models.Models.Packets.ServerPackets;

public class UpdateCardsPacket(BeatmapData[] maps) : ServerPacket
{
    public override ServerPacketTypes PacketType => ServerPacketTypes.UpdateCards;
    
    public readonly BeatmapData[] Maps = maps;
}