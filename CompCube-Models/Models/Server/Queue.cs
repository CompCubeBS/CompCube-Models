using Newtonsoft.Json;

namespace CompCube_Models.Models.Server;

[method: JsonConstructor]
public class Queue(string guid, string slug, string name, string poolGuid, bool competitive, bool enabled)
{
    [JsonProperty("guid")]
    public readonly string Guid = guid;
    
    [JsonProperty("slug")]
    public readonly string Slug = slug;
    
    [JsonProperty("name")]
    public readonly string Name = name;
    
    [JsonProperty("poolGuid")]
    public readonly string PoolGuid = poolGuid;
    
    [JsonProperty("competitive")]
    public readonly bool Competitive = competitive;
    
    [JsonProperty("enabled")]
    public readonly bool Enabled = enabled;
}