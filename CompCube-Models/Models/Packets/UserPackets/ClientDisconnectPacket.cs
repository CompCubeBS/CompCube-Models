namespace CompCube_Models.Models.Packets.UserPackets;

public class ClientDisconnectPacket : UserPacket
{
    public override UserPacketTypes PacketType => UserPacketTypes.ClientDisconnectPacket;
}