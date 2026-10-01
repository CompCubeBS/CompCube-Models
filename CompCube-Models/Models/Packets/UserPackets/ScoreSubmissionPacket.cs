using CompCube_Models.Models.Match;
using Newtonsoft.Json;

namespace CompCube_Models.Models.Packets.UserPackets;

public class ScoreSubmissionPacket : UserPacket
{
    public override UserPacketTypes PacketType => UserPacketTypes.ScoreSubmission;

    [JsonProperty("score")]
    public readonly Score Score;
    
    [JsonConstructor]
    public ScoreSubmissionPacket(Score score)
    {
        Score = score;
    }
}