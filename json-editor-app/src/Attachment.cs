using Newtonsoft.Json;
using System.Collections.Generic;

public class Attachment
{
    [JsonProperty("itemnames")]
    public List<string> ItemNames { get; set; } = new List<string>();

    [JsonProperty("hiddenSelectionTextures")]
    public List<string> HiddenSelectionTextures { get; set; } = new List<string>();

    [JsonProperty("hiddenSelectionMaterials")]
    public List<string> HiddenSelectionMaterials { get; set; } = new List<string>();
}

