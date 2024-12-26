using System.Collections.Generic;

public class Repaint
{
    public string Name { get; set; }
    public string OverwrittenDisplayName { get; set; }
    public List<string> HiddenSelectionTextures { get; set; } = new List<string>();
    public List<string> HiddenSelectionMaterials { get; set; } = new List<string>();
    public List<string> PermissionGroups { get; set; } = new List<string>();
    public List<Attachment> Attachments { get; set; } = new List<Attachment>();
}
