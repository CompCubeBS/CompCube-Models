using Newtonsoft.Json;

namespace CompCube_Models.Models.ClientData;

[method: JsonConstructor]
public class UserStatistics(string userName, string platformId, string? beatKhanaId, string avatarUrl, Flair? flair, bool banned, long rank, int elo, int wins, int totalGames, int winstreak, int highestWinstreak) : UserInfo(userName, platformId, beatKhanaId, avatarUrl, flair, banned)
{
    [JsonProperty("elo")]
    public int Elo { get; private set; } = elo;
    
    [JsonProperty("rank")]
    public long Rank { get; private set; }= rank;
    
    [JsonProperty("wins")] 
    public int Wins { get; private set; } = wins;
    
    [JsonProperty("losses")] 
    public int TotalGames { get; private set; } = totalGames;
    
    [JsonProperty("winstreak")] 
    public int Winstreak { get; private set; } = winstreak;
    
    [JsonProperty("highestWinstreak")] 
    public int HighestWinstreak { get; private set; } = highestWinstreak;
}