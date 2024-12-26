using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using json_editor_app.Models;

namespace json_editor_app
{
    public partial class MainForm : Form
    {
        private string jsonFilePath = @"D:\C#\SkinEditor\json-editor-app\json\Repaints.json";
        private BindingSource bindingSourceItemNames = new BindingSource();
        private BindingSource bindingSourceRepaints = new BindingSource();
        private List<ItemName> itemNames;

        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                var jsonData = File.ReadAllText(jsonFilePath);
                itemNames = JsonConvert.DeserializeObject<List<ItemName>>(jsonData);
                bindingSourceItemNames.DataSource = itemNames.SelectMany(i => i.ItemNames).ToList();
                listBoxItemNames.DataSource = bindingSourceItemNames;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading JSON: {ex.Message}");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var jsonData = JsonConvert.SerializeObject(itemNames, Formatting.Indented);
                File.WriteAllText(jsonFilePath, jsonData);
                MessageBox.Show("JSON saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving JSON: {ex.Message}");
            }
        }

        private void ListBoxItemNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = listBoxItemNames.SelectedIndex;
            if (selectedIndex >= 0 && itemNames != null)
            {
                var selectedItemName = listBoxItemNames.SelectedItem.ToString();
                var selectedItem = itemNames.FirstOrDefault(i => i.ItemNames.Contains(selectedItemName));
                if (selectedItem != null)
                {
                    bindingSourceRepaints.DataSource = selectedItem.Repaints;
                    listBoxRepaints.DataSource = bindingSourceRepaints;
                    listBoxRepaints.DisplayMember = "Name";
                }
            }
        }

        private void ListBoxRepaints_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItemIndex = listBoxItemNames.SelectedIndex;
            var selectedRepaintIndex = listBoxRepaints.SelectedIndex;
            if (selectedItemIndex >= 0 && selectedRepaintIndex >= 0 && itemNames != null)
            {
                var selectedItemName = listBoxItemNames.SelectedItem.ToString();
                var selectedItem = itemNames.FirstOrDefault(i => i.ItemNames.Contains(selectedItemName));
                if (selectedItem != null)
                {
                    var repaint = selectedItem.Repaints[selectedRepaintIndex];
                    textBoxName.Text = repaint.Name;
                    textBoxOverwrittenDisplayName.Text = repaint.OverwrittenDisplayName;
                    textBoxHiddenSelectionTextures.Text = string.Join(Environment.NewLine, repaint.HiddenSelectionTextures);
                    textBoxHiddenSelectionMaterials.Text = string.Join(Environment.NewLine, repaint.HiddenSelectionMaterials);
                    textBoxPermissionGroups.Text = string.Join(Environment.NewLine, repaint.PermissionGroups);
                    textBoxAttachments.Text = string.Join(Environment.NewLine, repaint.Attachments.Select(a => $"ItemNames: {string.Join(", ", a.ItemNames)}\nHiddenSelectionTextures: {string.Join(", ", a.HiddenSelectionTextures)}\nHiddenSelectionMaterials: {string.Join(", ", a.HiddenSelectionMaterials)}"));
                }
            }
        }

        private void AddItemNameButton_Click(object sender, EventArgs e)
        {
            var itemName = Prompt.ShowDialog("Enter item name:", "Add Item");
            if (!string.IsNullOrWhiteSpace(itemName))
            {
                var newItem = new ItemName { ItemNames = new List<string> { itemName }, Repaints = new List<Repaint>() };
                itemNames.Add(newItem);
                bindingSourceItemNames.DataSource = itemNames.SelectMany(i => i.ItemNames).ToList();
            }
        }

        private void RemoveItemNameButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = listBoxItemNames.SelectedIndex;
            if (selectedIndex >= 0)
            {
                var selectedItemName = listBoxItemNames.SelectedItem.ToString();
                var selectedItem = itemNames.FirstOrDefault(i => i.ItemNames.Contains(selectedItemName));
                if (selectedItem != null)
                {
                    itemNames.Remove(selectedItem);
                    bindingSourceItemNames.DataSource = itemNames.SelectMany(i => i.ItemNames).ToList();
                }
            }
        }

        private void AddRepaintButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = listBoxItemNames.SelectedIndex;
            if (selectedIndex >= 0)
            {
                var repaintName = Prompt.ShowDialog("Enter repaint name:", "Add Repaint");
                if (!string.IsNullOrWhiteSpace(repaintName))
                {
                    var selectedItemName = listBoxItemNames.SelectedItem.ToString();
                    var selectedItem = itemNames.FirstOrDefault(i => i.ItemNames.Contains(selectedItemName));
                    if (selectedItem != null)
                    {
                        selectedItem.Repaints.Add(new Repaint { Name = repaintName });
                        bindingSourceRepaints.DataSource = selectedItem.Repaints;
                    }
                }
            }
        }

        private void RemoveRepaintButton_Click(object sender, EventArgs e)
        {
            var selectedItemIndex = listBoxItemNames.SelectedIndex;
            var selectedRepaintIndex = listBoxRepaints.SelectedIndex;
            if (selectedItemIndex >= 0 && selectedRepaintIndex >= 0)
            {
                var selectedItemName = listBoxItemNames.SelectedItem.ToString();
                var selectedItem = itemNames.FirstOrDefault(i => i.ItemNames.Contains(selectedItemName));
                if (selectedItem != null)
                {
                    selectedItem.Repaints.RemoveAt(selectedRepaintIndex);
                    bindingSourceRepaints.DataSource = selectedItem.Repaints;
                }
            }
        }
    }
}