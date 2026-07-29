using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.UserPackets;

public class JoinRequestPacket : UserPacket
{
    [JsonProperty("username")]
    public string UserName { get; private set; }
    
    [JsonProperty("userId")]
    public int UserId { get; private set; }

    [JsonProperty("queue")]
    public string Queue { get; private set; }
    
    [JsonConstructor]
    public JoinRequestPacket(string userName, int userId, string queue)
    {
        UserName = userName;
        UserId = userId;
        Queue = queue;
    }

    public override UserPacketTypes PacketType =>  UserPacketTypes.JoinRequest;
}