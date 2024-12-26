using System.Collections.Generic;

namespace json_editor_app.Models
{
    public class Category
    {
        public string Name { get; set; }
        public List<Item> Items { get; set; }
    }
}