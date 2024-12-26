using System.Collections.Generic;

namespace json_editor_app.Models
{
    public class Attachment
    {
        public List<string> ItemNames { get; set; } = new List<string>();
        public List<string> HiddenSelectionTextures { get; set; } = new List<string>();
        public List<string> HiddenSelectionMaterials { get; set; } = new List<string>();
    }
}