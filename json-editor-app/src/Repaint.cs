using Newtonsoft.Json;
using System.Collections.Generic;

public class Repaint
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("overwrittenDisplayName")]
    public string OverwrittenDisplayName { get; set; }

    [JsonProperty("excludedItems")]
    public List<string> ExcludedItems { get; set; } = new List<string>();

    [JsonProperty("hiddenSelectionTextures")]
    public List<string> HiddenSelectionTextures { get; set; } = new List<string>();

    [JsonProperty("hiddenSelectionMaterials")]
    public List<string> HiddenSelectionMaterials { get; set; } = new List<string>();

    [JsonProperty("permissionGroups")]
    public List<string> PermissionGroups { get; set; } = new List<string>();

    [JsonProperty("attachments")]
    public List<Attachment> Attachments { get; set; } = new List<Attachment>();
}
