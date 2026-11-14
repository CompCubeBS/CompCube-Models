using CompCube_Models.Models.ClientData;

namespace CompCube_Models.Models.Match;

public class MatchScore(UserProfile user, Score score)
{
    public readonly UserProfile User = user;
    public readonly Score Score = score;
}