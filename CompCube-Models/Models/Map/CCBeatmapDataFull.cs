using Newtonsoft.Json;

namespace CompCube_Models.Models.Map;

[method: JsonConstructor]
public class CCBeatmapDataFull(string? songTitle, string? songArtist, string? mapper, string? coverUrl, string guid, string hash, CCBeatmapData.DifficultyType difficulty, CCBeatmapData.Category category, int maxScore, int timeSeconds) : CCBeatmapData(guid, hash, difficulty, category, maxScore, timeSeconds)
{
    [JsonProperty("songTitle")]
    public readonly string? SongTitle = songTitle;
    
    [JsonProperty("songArtist")]
    public readonly string? SongArtist = songArtist;
    
    [JsonProperty("mapper")]
    public readonly string? Mapper = mapper;
    
    [JsonProperty("coverUrl")]
    public readonly string? CoverUrl = coverUrl;
}