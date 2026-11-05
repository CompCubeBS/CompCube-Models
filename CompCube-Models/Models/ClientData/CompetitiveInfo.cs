using Newtonsoft.Json;

namespace CompCube_Models.Models.ClientData;

public class CompetitiveInfo(int season, int elo, int rank, int wins, int totalGames, int winstreak, int highestWinstreak)
{
    [JsonProperty("season")]
    public int Season { get; private set; } = season;
    
    [JsonProperty("elo")]
    public int Elo { get; private set; } = elo;
    
    [JsonProperty("rank")]
    public int Rank { get; private set; }= rank;
    
    [JsonProperty("wins")] 
    public int Wins { get; private set; } = wins;
    
    [JsonProperty("totalGames")] 
    public int TotalGames { get; private set; } = totalGames;
    
    [JsonProperty("winstreak")] 
    public int Winstreak { get; private set; } = winstreak;
    
    [JsonProperty("highestWinstreak")] 
    public int HighestWinstreak { get; private set; } = highestWinstreak;
}