using CompCube_Models.Models.Packets.UserPackets;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CompCube_Models.Models.Packets;

public abstract class UserPacket : Packet
{
    [JsonProperty("type")]
    public abstract UserPacketTypes PacketType { get; }
    
    public static bool TryDeserialize(string json, out UserPacket? packet)
    {
        try
        {
            var jobj = JObject.Parse(json);

            if (!jobj.TryGetValue("type", out var packetTypeJToken) || !Enum.TryParse<UserPacketTypes>(packetTypeJToken.ToObject<string>(), out var userPacketType))
            {
                packet = null;
                return false;
            }

            packet = userPacketType switch
            {
                UserPacketTypes.MapSelection => JsonConvert.DeserializeObject<MapSelectionPacket>(json)!,
                UserPacketTypes.ScoreSubmission => JsonConvert.DeserializeObject<ScoreSubmissionPacket>(json)!,
                UserPacketTypes.DiscardMaps => JsonConvert.DeserializeObject<DiscardMapsPacket>(json)!,
                UserPacketTypes.ClientDisconnectPacket => JsonConvert.DeserializeObject<ClientDisconnectPacket>(json)!,
                _ => throw new Exception("Could not get packet type!")
            };

            return true;
        }
        catch
        {
            packet = null;
            return false;
        }
    }

    public enum UserPacketTypes
    {
        MapSelection,
        ScoreSubmission,
        DiscardMaps,
        ClientDisconnectPacket
    }
}