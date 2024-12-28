using Newtonsoft.Json;
using System.Collections.Generic;

public class ItemName
{
    [JsonProperty("itemnames")]
    public List<string> ItemNames { get; set; } = new List<string>();

    [JsonProperty("repaints")]
    public List<Repaint> Repaints { get; set; } = new List<Repaint>();
}
