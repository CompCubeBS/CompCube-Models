using Newtonsoft.Json;

namespace CompCube_Models.Models.ClientData;

public class RankData(int rank, int elo, int wins, int totalGames, int winstreak, int bestWinstreak)
{
    public readonly int Rank = rank;
    public readonly int Elo = elo;
    public readonly int Wins = wins;
    public readonly int TotalGames = totalGames;
    public readonly int Winstreak = winstreak;
    public readonly int BestWinstreak = bestWinstreak;
}