using Newtonsoft.Json;

namespace CompCube_Models.Models.Map;

[method: JsonConstructor]
public class BeatmapData(string guid,
    string hash,
    BeatmapData.DifficultyType difficulty,
    BeatmapData.Category category,
    int maxScore,
    int timeSeconds)
{
    protected bool Equals(BeatmapData other)
    {
        return Hash == other.Hash && Difficulty == other.Difficulty;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((BeatmapData)obj);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            return (Hash.GetHashCode() * 397) ^ (int)Difficulty;
        }
    }

    [JsonProperty("guid")] 
    public readonly string Guid = guid;

    [JsonProperty("hash")]
    public readonly string Hash = hash;

    [JsonProperty("difficulty")]
    public readonly DifficultyType Difficulty = difficulty;

    [JsonProperty("category")] 
    public readonly Category MapCategory = category;
    
    [JsonProperty("maxScore")]
    public readonly int MaxScore = maxScore;
    
    [JsonProperty("timeSeconds")]
    public readonly int TimeSeconds = timeSeconds;

    public enum Category
    {
        Accuracy,
        MidSpeed,
        Tech,
        Speed,
        Extreme,
        Special
    }
    
    public enum DifficultyType
    {
        Easy,
        Normal,
        Hard,
        Expert,
        ExpertPlus
    }

    public static bool operator ==(BeatmapData a, BeatmapData b)
    {
        return a.Hash == b.Hash && a.Difficulty == b.Difficulty;
    }

    public static bool operator !=(BeatmapData a, BeatmapData b) => !(a == b);
}