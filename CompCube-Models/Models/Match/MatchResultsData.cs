using CompCube_Models.Models.ClientData;
using CompCube_Models.Models.Map;

namespace CompCube_Models.Models.Match;

public class MatchResultsData(UserProfileFull[] winners, UserProfileFull[] losers, int mmrChange, bool premature, int id, DateTime time)
{
    public readonly UserProfileFull[] Winner = winners;
    public readonly UserProfileFull[] Loser = losers;
    public readonly int MmrChange = mmrChange;
    public readonly bool Premature = premature;
    public readonly int Id = id;
    public readonly DateTime Time = time;
}