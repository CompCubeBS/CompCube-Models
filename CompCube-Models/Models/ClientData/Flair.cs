using Newtonsoft.Json;

namespace CompCube_Models.Models.ClientData;

[method: JsonConstructor]
public class Flair(string guid, string name, string colorCode, string[] permissions)
{
    [JsonProperty("guid")] public string Guid { get; private set; } = guid;
    
    [JsonProperty("badgeName")]
    public string Name { get; private set; } = name;

    [JsonProperty("badgeColor")]
    public string ColorCode { get; private set; } = colorCode;
    
    [JsonProperty("permissions")]
    public string[] Permissions { get; private set; } = permissions;
}