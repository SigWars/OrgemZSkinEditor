using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using json_editor_app.Models;
using Newtonsoft.Json.Serialization;
using System.Windows.Controls;

namespace json_editor_app
{
    public partial class MainForm : Form
    {
        private BindingSource bindingSourceItemNames = new BindingSource();
        private BindingSource bindingSourceRepaints = new BindingSource();
        private List<ItemName> itemNames;
        private string currentFilePath;

        public MainForm()
        {
            InitializeComponent();
            textBoxName.Leave += TextBoxName_Leave;
            LoadItemNamesToComboBox(); // Carregar itens na ComboBox ao inicializar o formulário
        }

        private void MoveItemButton_Click(object sender, EventArgs e)
        {
            var selectedIndices = listBoxItemNames.SelectedIndices;
            if (selectedIndices.Count > 0)
            {
                var selectedItems = selectedIndices.Cast<int>().Select(index => listBoxItemNames.Items[index].ToString()).ToList();
                var itemNamesList = itemNames.SelectMany(i => i.ItemNames).ToList();
                using (var dialog = new MoveCopyDialog(itemNamesList))
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        var targetItemName = dialog.SelectedItemName;
                        var targetItem = itemNames.FirstOrDefault(i => i.ItemNames.Contains(targetItemName));
                        if (targetItem != null)
                        {
                            foreach (var selectedItemName in selectedItems)
                            {
                                var selectedItem = itemNames.FirstOrDefault(i => i.ItemNames.Contains(selectedItemName));
                                if (selectedItem != null)
                                {
                                    // Mover o item
                                    targetItem.ItemNames.Add(selectedItemName);
                                    selectedItem.ItemNames.Remove(selectedItemName);
                                    if (selectedItem.ItemNames.Count == 0)
                                    {
                                        itemNames.Remove(selectedItem);
                                    }

                                    // Copiar todos os repaints para o novo item
                                    targetItem.Repaints.AddRange(selectedItem.Repaints);
                                }
                            }

                            bindingSourceItemNames.DataSource = itemNames.SelectMany(i => i.ItemNames).ToList();
                            LoadItemNamesToComboBox(); // Atualizar ComboBox após mover itens
                        }
                    }
                }
            }
        }

        private void CopyItemButton_Click(object sender, EventArgs e)
        {
            var selectedIndices = listBoxItemNames.SelectedIndices;
            if (selectedIndices.Count > 0)
            {
                var selectedItems = selectedIndices.Cast<int>().Select(index => listBoxItemNames.Items[index].ToString()).ToList();
                var itemNamesList = itemNames.SelectMany(i => i.ItemNames).ToList();
                using (var dialog = new MoveCopyDialog(itemNamesList))
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        var targetItemName = dialog.SelectedItemName;
                        var targetItem = itemNames.FirstOrDefault(i => i.ItemNames.Contains(targetItemName));
                        if (targetItem != null)
                        {
                            foreach (var selectedItemName in selectedItems)
                            {
                                var selectedItem = itemNames.FirstOrDefault(i => i.ItemNames.Contains(selectedItemName));
                                if (selectedItem != null)
                                {
                                    // Copiar o item
                                    targetItem.ItemNames.Add(selectedItemName);

                                    // Copiar todos os repaints para o novo item
                                    targetItem.Repaints.AddRange(selectedItem.Repaints.Select(r => new Repaint
                                    {
                                        Name = r.Name,
                                        OverwrittenDisplayName = r.OverwrittenDisplayName,
                                        ExcludedItems = new List<string>(r.ExcludedItems),
                                        HiddenSelectionTextures = new List<string>(r.HiddenSelectionTextures),
                                        HiddenSelectionMaterials = new List<string>(r.HiddenSelectionMaterials),
                                        PermissionGroups = new List<string>(r.PermissionGroups),
                                        Attachments = r.Attachments.Select(a => new Attachment
                                        {
                                            ItemNames = new List<string>(a.ItemNames),
                                            HiddenSelectionTextures = new List<string>(a.HiddenSelectionTextures),
                                            HiddenSelectionMaterials = new List<string>(a.HiddenSelectionMaterials)
                                        }).ToList()
                                    }));
                                }
                            }

                            bindingSourceItemNames.DataSource = itemNames.SelectMany(i => i.ItemNames).ToList();
                            LoadItemNamesToComboBox(); // Atualizar ComboBox após copiar itens
                        }
                    }
                }
            }
        }

        // Código existente...

        private void LoadButton_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new System.Windows.Forms.OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var jsonFilePath = openFileDialog.FileName;
                        var jsonData = File.ReadAllText(jsonFilePath);
                        itemNames = JsonConvert.DeserializeObject<List<ItemName>>(jsonData);
                        bindingSourceItemNames.DataSource = itemNames.SelectMany(i => i.ItemNames).ToList();
                        listBoxItemNames.DataSource = bindingSourceItemNames;
                        currentFilePath = jsonFilePath;
                        RefreshForm();
                        LoadItemNamesToComboBox(); // Atualizar ComboBox após carregar o arquivo
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading JSON: {ex.Message}");
                    }
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SaveAsButton_Click(sender, e);
            }
            else
            {
                SaveToFile(currentFilePath);
            }
        }

        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new System.Windows.Forms.SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SaveToFile(saveFileDialog.FileName);
                }
            }
        }

        public class PreserveCaseContractResolver : DefaultContractResolver
        {
            protected override string ResolvePropertyName(string propertyName)
            {
                return propertyName;
            }
        }

        private void SaveToFile(string filePath)
        {
            try
            {
                // Atualizar os dados dos repaints com os valores dos campos de texto
                var selectedItemIndex = listBoxItemNames.SelectedIndex;
                var selectedRepaintIndex = listBoxRepaints.SelectedIndex;
                if (selectedItemIndex >= 0 && selectedRepaintIndex >= 0 && itemNames != null)
                {
                    var selectedItemName = listBoxItemNames.SelectedItem.ToString();
                    var selectedItem = itemNames.FirstOrDefault(i => i.ItemNames.Contains(selectedItemName));
                    if (selectedItem != null && selectedRepaintIndex < selectedItem.Repaints.Count)
                    {
                        var repaint = selectedItem.Repaints[selectedRepaintIndex];
                        repaint.Name = textBoxName.Text;
                        repaint.OverwrittenDisplayName = textBoxOverwrittenDisplayName.Text;
                        repaint.ExcludedItems = textBoxExcludedItems.Text
                            .Split(new[] { Environment.NewLine }, StringSplitOptions.None)
                            .Where(s => !string.IsNullOrWhiteSpace(s))
                            .ToList();
                        repaint.HiddenSelectionTextures = textBoxHiddenSelectionTextures.Text
                            .Split(new[] { Environment.NewLine }, StringSplitOptions.None)
                            .Where(s => !string.IsNullOrWhiteSpace(s))
                            .ToList();
                        repaint.HiddenSelectionMaterials = textBoxHiddenSelectionMaterials.Text
                            .Split(new[] { Environment.NewLine }, StringSplitOptions.None)
                            .Where(s => !string.IsNullOrWhiteSpace(s))
                            .ToList();
                        repaint.PermissionGroups = textBoxPermissionGroups.Text
                            .Split(new[] { Environment.NewLine }, StringSplitOptions.None)
                            .Where(s => !string.IsNullOrWhiteSpace(s))
                            .ToList();

                        // Atualizar os dados dos attachments
                        if (repaint.Attachments.Count > 0)
                        {
                            var attachment = repaint.Attachments[0];
                            attachment.ItemNames = textBoxAttachmentItemNames.Text
                                .Split(new[] { Environment.NewLine }, StringSplitOptions.None)
                                .Where(s => !string.IsNullOrWhiteSpace(s))
                                .ToList();
                            attachment.HiddenSelectionTextures = textBoxAttachmentHiddenSelectionTextures.Text
                                .Split(new[] { Environment.NewLine }, StringSplitOptions.None)
                                .Where(s => !string.IsNullOrWhiteSpace(s))
                                .ToList();
                            attachment.HiddenSelectionMaterials = textBoxAttachmentHiddenSelectionMaterials.Text
                                .Split(new[] { Environment.NewLine }, StringSplitOptions.None)
                                .Where(s => !string.IsNullOrWhiteSpace(s))
                                .ToList();
                        }
                        else
                        {
                            var newAttachment = new Attachment
                            {
                                ItemNames = textBoxAttachmentItemNames.Text
                                    .Split(new[] { Environment.NewLine }, StringSplitOptions.None)
                                    .Where(s => !string.IsNullOrWhiteSpace(s))
                                    .ToList(),
                                HiddenSelectionTextures = textBoxAttachmentHiddenSelectionTextures.Text
                                    .Split(new[] { Environment.NewLine }, StringSplitOptions.None)
                                    .Where(s => !string.IsNullOrWhiteSpace(s))
                                    .ToList(),
                                HiddenSelectionMaterials = textBoxAttachmentHiddenSelectionMaterials.Text
                                    .Split(new[] { Environment.NewLine }, StringSplitOptions.None)
                                    .Where(s => !string.IsNullOrWhiteSpace(s))
                                    .ToList()
                            };
                            repaint.Attachments.Add(newAttachment);
                        }
                    }
                }

                // Serializar o JSON com as chaves preservando o caso sensível
                var jsonData = JsonConvert.SerializeObject(itemNames, Formatting.Indented, new JsonSerializerSettings
                {
                    ContractResolver = new PreserveCaseContractResolver()
                });
                File.WriteAllText(filePath, jsonData);
                MessageBox.Show("JSON saved successfully.");
                currentFilePath = filePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving JSON: {ex.Message}");
            }
        }

        private void SaveFinalVersionButton_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new System.Windows.Forms.SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Salva o arquivo carregado
                    SaveToFile(currentFilePath);
                    // Salva o arquivo sem --
                    SaveFinalVersionToFile(saveFileDialog.FileName);
                }
            }
        }

        private void SaveFinalVersionToFile(string filePath)
        {
            try
            {
                var finalItemNames = itemNames
                    .Select(i => new ItemName
                    {
                        ItemNames = i.ItemNames.Where(name => !name.StartsWith("--")).ToList(),
                        Repaints = i.Repaints
                    })
                    .Where(i => i.ItemNames.Count > 0)
                    .ToList();

                var jsonData = JsonConvert.SerializeObject(finalItemNames, Formatting.Indented, new JsonSerializerSettings
                {
                    ContractResolver = new PreserveCaseContractResolver()
                });
                File.WriteAllText(filePath, jsonData);
                MessageBox.Show("Final version JSON saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving final version JSON: {ex.Message}");
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
                    listBoxRepaints.DisplayMember = "name";
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
                if (selectedItem != null && selectedRepaintIndex < selectedItem.Repaints.Count)
                {
                    var repaint = selectedItem.Repaints[selectedRepaintIndex];
                    textBoxName.Text = repaint.Name;
                    textBoxOverwrittenDisplayName.Text = repaint.OverwrittenDisplayName;
                    textBoxExcludedItems.Text = string.Join(Environment.NewLine, repaint.ExcludedItems);
                    textBoxHiddenSelectionTextures.Text = string.Join(Environment.NewLine, repaint.HiddenSelectionTextures);
                    textBoxHiddenSelectionMaterials.Text = string.Join(Environment.NewLine, repaint.HiddenSelectionMaterials);
                    textBoxPermissionGroups.Text = string.Join(Environment.NewLine, repaint.PermissionGroups);

                    if (repaint.Attachments != null && repaint.Attachments.Count > 0)
                    {
                        var attachment = repaint.Attachments[0];
                        textBoxAttachmentItemNames.Text = string.Join(Environment.NewLine, attachment.ItemNames);
                        textBoxAttachmentHiddenSelectionTextures.Text = string.Join(Environment.NewLine, attachment.HiddenSelectionTextures);
                        textBoxAttachmentHiddenSelectionMaterials.Text = string.Join(Environment.NewLine, attachment.HiddenSelectionMaterials);
                    }
                    else
                    {
                        textBoxAttachmentItemNames.Clear();
                        textBoxAttachmentHiddenSelectionTextures.Clear();
                        textBoxAttachmentHiddenSelectionMaterials.Clear();
                    }
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
                LoadItemNamesToComboBox(); // Atualizar ComboBox após adicionar novo item
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
                    selectedItem.ItemNames.Remove(selectedItemName);
                    if (selectedItem.ItemNames.Count == 0)
                    {
                        itemNames.Remove(selectedItem);
                    }
                    bindingSourceItemNames.DataSource = itemNames.SelectMany(i => i.ItemNames).ToList();
                    LoadItemNamesToComboBox(); // Atualizar ComboBox após remover item
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
                        listBoxRepaints.DataSource = null;
                        listBoxRepaints.DataSource = bindingSourceRepaints;
                        listBoxRepaints.DisplayMember = "name";
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
                if (selectedItem != null && selectedRepaintIndex < selectedItem.Repaints.Count)
                {
                    selectedItem.Repaints.RemoveAt(selectedRepaintIndex);
                    bindingSourceRepaints.DataSource = selectedItem.Repaints;
                    listBoxRepaints.DataSource = null;
                    listBoxRepaints.DataSource = bindingSourceRepaints;
                    listBoxRepaints.DisplayMember = "name";
                }
            }
        }

        private void AddStringToItemNameButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = listBoxItemNames.SelectedIndex;
            if (selectedIndex >= 0)
            {
                var newItemName = Prompt.ShowDialog("Enter new item name:", "Add String to Item Names");
                if (!string.IsNullOrWhiteSpace(newItemName))
                {
                    var selectedItemName = listBoxItemNames.SelectedItem.ToString();
                    var selectedItem = itemNames.FirstOrDefault(i => i.ItemNames.Contains(selectedItemName));
                    if (selectedItem != null)
                    {
                        selectedItem.ItemNames.Add(newItemName);
                        bindingSourceItemNames.DataSource = itemNames.SelectMany(i => i.ItemNames).ToList();
                        LoadItemNamesToComboBox(); // Atualizar ComboBox após adicionar novo nome de item
                    }
                }
            }
        }

        private void MoveRepaintButton_Click(object sender, EventArgs e)
        {
            var selectedItemIndex = listBoxItemNames.SelectedIndex;
            var selectedRepaintIndex = listBoxRepaints.SelectedIndex;
            if (selectedItemIndex >= 0 && selectedRepaintIndex >= 0)
            {
                var selectedItemName = listBoxItemNames.SelectedItem.ToString();
                var selectedItem = itemNames.FirstOrDefault(i => i.ItemNames.Contains(selectedItemName));
                if (selectedItem != null && selectedRepaintIndex < selectedItem.Repaints.Count)
                {
                    var repaint = selectedItem.Repaints[selectedRepaintIndex];
                    var itemNamesList = itemNames.SelectMany(i => i.ItemNames).ToList();
                    using (var dialog = new MoveCopyDialog(itemNamesList))
                    {
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            var targetItemName = dialog.SelectedItemName;
                            var targetItem = itemNames.FirstOrDefault(i => i.ItemNames.Contains(targetItemName));
                            if (targetItem != null)
                            {
                                targetItem.Repaints.Add(repaint);
                                selectedItem.Repaints.RemoveAt(selectedRepaintIndex);
                                bindingSourceRepaints.DataSource = selectedItem.Repaints;
                                listBoxRepaints.DataSource = null;
                                listBoxRepaints.DataSource = bindingSourceRepaints;
                                listBoxRepaints.DisplayMember = "name";
                            }
                        }
                    }
                }
            }
        }

        private void CopyRepaintButton_Click(object sender, EventArgs e)
        {
            var selectedItemIndex = listBoxItemNames.SelectedIndex;
            var selectedRepaintIndex = listBoxRepaints.SelectedIndex;
            if (selectedItemIndex >= 0 && selectedRepaintIndex >= 0)
            {
                var selectedItemName = listBoxItemNames.SelectedItem.ToString();
                var selectedItem = itemNames.FirstOrDefault(i => i.ItemNames.Contains(selectedItemName));
                if (selectedItem != null && selectedRepaintIndex < selectedItem.Repaints.Count)
                {
                    var repaint = selectedItem.Repaints[selectedRepaintIndex];
                    var itemNamesList = itemNames.SelectMany(i => i.ItemNames).ToList();
                    using (var dialog = new MoveCopyDialog(itemNamesList))
                    {
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            var targetItemName = dialog.SelectedItemName;
                            var targetItem = itemNames.FirstOrDefault(i => i.ItemNames.Contains(targetItemName));
                            if (targetItem != null)
                            {
                                var newRepaint = new Repaint
                                {
                                    Name = repaint.Name,
                                    OverwrittenDisplayName = repaint.OverwrittenDisplayName,
                                    ExcludedItems = new List<string>(repaint.ExcludedItems),
                                    HiddenSelectionTextures = new List<string>(repaint.HiddenSelectionTextures),
                                    HiddenSelectionMaterials = new List<string>(repaint.HiddenSelectionMaterials),
                                    PermissionGroups = new List<string>(repaint.PermissionGroups),
                                    Attachments = repaint.Attachments.Select(a => new Attachment
                                    {
                                        ItemNames = new List<string>(a.ItemNames),
                                        HiddenSelectionTextures = new List<string>(a.HiddenSelectionTextures),
                                        HiddenSelectionMaterials = new List<string>(a.HiddenSelectionMaterials)
                                    }).ToList()
                                };
                                targetItem.Repaints.Add(newRepaint);
                                bindingSourceRepaints.DataSource = selectedItem.Repaints;
                                listBoxRepaints.DataSource = null;
                                listBoxRepaints.DataSource = bindingSourceRepaints;
                                listBoxRepaints.DisplayMember = "name";
                            }
                        }
                    }
                }
            }
        }

        private void RefreshForm()
        {
            textBoxName.Clear();
            textBoxOverwrittenDisplayName.Clear();
            textBoxExcludedItems.Clear();
            textBoxHiddenSelectionTextures.Clear();
            textBoxHiddenSelectionMaterials.Clear();
            textBoxPermissionGroups.Clear();
            textBoxAttachmentItemNames.Clear();
            textBoxAttachmentHiddenSelectionTextures.Clear();
            textBoxAttachmentHiddenSelectionMaterials.Clear();
            listBoxItemNames.ClearSelected();
            listBoxRepaints.ClearSelected();
            bindingSourceRepaints.DataSource = null;
        }

        private void TextBoxName_Leave(object sender, EventArgs e)
        {
            textBoxOverwrittenDisplayName.Text = $"$original$ ({textBoxName.Text})";
        }

        private void ComboBoxItemNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lógica para manipular a seleção do ComboBox
            string selectedItem = comboBoxItemNames.SelectedItem.ToString();
            // Atualize a interface do usuário com base no item selecionado
            var selectedItemName = selectedItem;
            var selectedItemObj = itemNames.FirstOrDefault(i => i.ItemNames.Contains(selectedItemName));
            if (selectedItemObj != null)
            {
                var filteredItemNames = selectedItemObj.ItemNames.Where(name => !name.StartsWith("--")).ToList();
                bindingSourceItemNames.DataSource = filteredItemNames;
                listBoxItemNames.DataSource = bindingSourceItemNames;
            }
        }

        private void LoadItemNamesToComboBox()
        {
            if (itemNames != null)
            {
                var itemNamesList = itemNames.SelectMany(i => i.ItemNames)
                                             .Where(name => name.StartsWith("--"))
                                             .ToList();
                comboBoxItemNames.Items.Clear();
                comboBoxItemNames.Items.AddRange(itemNamesList.ToArray());
            }
        }

        private void RenameItemNameButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = listBoxItemNames.SelectedIndex;
            if (selectedIndex >= 0)
            {
                var selectedItemName = listBoxItemNames.SelectedItem.ToString();
                var newItemName = Prompt.ShowDialog("Enter new item name:", "Rename Item", selectedItemName);
                if (!string.IsNullOrWhiteSpace(newItemName))
                {
                    var selectedItem = itemNames.FirstOrDefault(i => i.ItemNames.Contains(selectedItemName));
                    if (selectedItem != null)
                    {
                        var index = selectedItem.ItemNames.IndexOf(selectedItemName);
                        if (index >= 0)
                        {
                            selectedItem.ItemNames[index] = newItemName;
                            bindingSourceItemNames.DataSource = itemNames.SelectMany(i => i.ItemNames).ToList();
                            LoadItemNamesToComboBox(); // Atualizar ComboBox após renomear item
                        }
                    }
                }
            }
        }
    }
}


