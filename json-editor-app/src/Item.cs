using System.Collections.Generic;

namespace json_editor_app.Models
{
    public class Item
    {
        public string Name { get; set; }
        public List<string> SubItems { get; set; }
    }
}