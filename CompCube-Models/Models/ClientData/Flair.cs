using Newtonsoft.Json;

namespace CompCube_Models.Models.ClientData;

[method: JsonConstructor]
public class Flair(string name, string colorCode)
{
    [JsonProperty("badgeName")]
    public string Name { get; private set; } = name;

    [JsonProperty("badgeColor")]
    public string ColorCode { get; private set; } = colorCode;
}