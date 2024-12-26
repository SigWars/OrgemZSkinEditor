using System.Windows.Forms;

namespace json_editor_app
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxItemNames;
        private System.Windows.Forms.ListBox listBoxRepaints;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxOverwrittenDisplayName;
        private System.Windows.Forms.TextBox textBoxHiddenSelectionTextures;
        private System.Windows.Forms.TextBox textBoxHiddenSelectionMaterials;
        private System.Windows.Forms.TextBox textBoxPermissionGroups;
        private System.Windows.Forms.TextBox textBoxAttachmentItemNames;
        private System.Windows.Forms.TextBox textBoxAttachmentHiddenSelectionTextures;
        private System.Windows.Forms.TextBox textBoxAttachmentHiddenSelectionMaterials;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button saveAsButton;
        private System.Windows.Forms.Button addItemNameButton;
        private System.Windows.Forms.Button removeItemNameButton;
        private System.Windows.Forms.Button addRepaintButton;
        private System.Windows.Forms.Button removeRepaintButton;
        private System.Windows.Forms.Button addStringToItemNameButton;
        private System.Windows.Forms.Label labelItemNames;
        private System.Windows.Forms.Label labelRepaints;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelOverwrittenDisplayName;
        private System.Windows.Forms.Label labelHiddenSelectionTextures;
        private System.Windows.Forms.Label labelHiddenSelectionMaterials;
        private System.Windows.Forms.Label labelPermissionGroups;
        private System.Windows.Forms.Label labelAttachmentItemNames;
        private System.Windows.Forms.Label labelAttachmentHiddenSelectionTextures;
        private System.Windows.Forms.Label labelAttachmentHiddenSelectionMaterials;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listBoxItemNames = new System.Windows.Forms.ListBox();
            this.listBoxRepaints = new System.Windows.Forms.ListBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxOverwrittenDisplayName = new System.Windows.Forms.TextBox();
            this.textBoxHiddenSelectionTextures = new System.Windows.Forms.TextBox();
            this.textBoxHiddenSelectionMaterials = new System.Windows.Forms.TextBox();
            this.textBoxPermissionGroups = new System.Windows.Forms.TextBox();
            this.textBoxAttachmentItemNames = new System.Windows.Forms.TextBox();
            this.textBoxAttachmentHiddenSelectionTextures = new System.Windows.Forms.TextBox();
            this.textBoxAttachmentHiddenSelectionMaterials = new System.Windows.Forms.TextBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveAsButton = new System.Windows.Forms.Button();
            this.addItemNameButton = new System.Windows.Forms.Button();
            this.removeItemNameButton = new System.Windows.Forms.Button();
            this.addRepaintButton = new System.Windows.Forms.Button();
            this.removeRepaintButton = new System.Windows.Forms.Button();
            this.addStringToItemNameButton = new System.Windows.Forms.Button();
            this.labelItemNames = new System.Windows.Forms.Label();
            this.labelRepaints = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelOverwrittenDisplayName = new System.Windows.Forms.Label();
            this.labelHiddenSelectionTextures = new System.Windows.Forms.Label();
            this.labelHiddenSelectionMaterials = new System.Windows.Forms.Label();
            this.labelPermissionGroups = new System.Windows.Forms.Label();
            this.labelAttachmentItemNames = new System.Windows.Forms.Label();
            this.labelAttachmentHiddenSelectionTextures = new System.Windows.Forms.Label();
            this.labelAttachmentHiddenSelectionMaterials = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxItemNames
            // 
            this.listBoxItemNames.FormattingEnabled = true;
            this.listBoxItemNames.Location = new System.Drawing.Point(12, 28);
            this.listBoxItemNames.Name = "listBoxItemNames";
            this.listBoxItemNames.Size = new System.Drawing.Size(200, 520);
            this.listBoxItemNames.TabIndex = 0;
            this.listBoxItemNames.SelectedIndexChanged += new System.EventHandler(this.ListBoxItemNames_SelectedIndexChanged);
            // 
            // listBoxRepaints
            // 
            this.listBoxRepaints.FormattingEnabled = true;
            this.listBoxRepaints.Location = new System.Drawing.Point(218, 28);
            this.listBoxRepaints.Name = "listBoxRepaints";
            this.listBoxRepaints.Size = new System.Drawing.Size(200, 520);
            this.listBoxRepaints.TabIndex = 1;
            this.listBoxRepaints.SelectedIndexChanged += new System.EventHandler(this.ListBoxRepaints_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(424, 28);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(364, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxOverwrittenDisplayName
            // 
            this.textBoxOverwrittenDisplayName.Location = new System.Drawing.Point(424, 67);
            this.textBoxOverwrittenDisplayName.Name = "textBoxOverwrittenDisplayName";
            this.textBoxOverwrittenDisplayName.Size = new System.Drawing.Size(364, 20);
            this.textBoxOverwrittenDisplayName.TabIndex = 3;
            // 
            // textBoxHiddenSelectionTextures
            // 
            this.textBoxHiddenSelectionTextures.Location = new System.Drawing.Point(424, 106);
            this.textBoxHiddenSelectionTextures.Multiline = true;
            this.textBoxHiddenSelectionTextures.Name = "textBoxHiddenSelectionTextures";
            this.textBoxHiddenSelectionTextures.Size = new System.Drawing.Size(500, 60);
            this.textBoxHiddenSelectionTextures.TabIndex = 4;
            // 
            // textBoxHiddenSelectionMaterials
            // 
            this.textBoxHiddenSelectionMaterials.Location = new System.Drawing.Point(424, 186);
            this.textBoxHiddenSelectionMaterials.Multiline = true;
            this.textBoxHiddenSelectionMaterials.Name = "textBoxHiddenSelectionMaterials";
            this.textBoxHiddenSelectionMaterials.Size = new System.Drawing.Size(500, 60);
            this.textBoxHiddenSelectionMaterials.TabIndex = 5;
            // 
            // textBoxPermissionGroups
            // 
            this.textBoxPermissionGroups.Location = new System.Drawing.Point(424, 266);
            this.textBoxPermissionGroups.Multiline = true;
            this.textBoxPermissionGroups.Name = "textBoxPermissionGroups";
            this.textBoxPermissionGroups.Size = new System.Drawing.Size(364, 60);
            this.textBoxPermissionGroups.TabIndex = 6;
            // 
            // textBoxAttachmentItemNames
            // 
            this.textBoxAttachmentItemNames.Location = new System.Drawing.Point(424, 346);
            this.textBoxAttachmentItemNames.Multiline = true;
            this.textBoxAttachmentItemNames.Name = "textBoxAttachmentItemNames";
            this.textBoxAttachmentItemNames.Size = new System.Drawing.Size(364, 60);
            this.textBoxAttachmentItemNames.TabIndex = 8;
            // 
            // textBoxAttachmentHiddenSelectionTextures
            // 
            this.textBoxAttachmentHiddenSelectionTextures.Location = new System.Drawing.Point(424, 426);
            this.textBoxAttachmentHiddenSelectionTextures.Multiline = true;
            this.textBoxAttachmentHiddenSelectionTextures.Name = "textBoxAttachmentHiddenSelectionTextures";
            this.textBoxAttachmentHiddenSelectionTextures.Size = new System.Drawing.Size(500, 60);
            this.textBoxAttachmentHiddenSelectionTextures.TabIndex = 9;
            // 
            // textBoxAttachmentHiddenSelectionMaterials
            // 
            this.textBoxAttachmentHiddenSelectionMaterials.Location = new System.Drawing.Point(424, 506);
            this.textBoxAttachmentHiddenSelectionMaterials.Multiline = true;
            this.textBoxAttachmentHiddenSelectionMaterials.Name = "textBoxAttachmentHiddenSelectionMaterials";
            this.textBoxAttachmentHiddenSelectionMaterials.Size = new System.Drawing.Size(500, 60);
            // loadButton
            this.loadButton.Location = new System.Drawing.Point(650, 570);
            this.loadButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 11;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);

            // saveButton
            this.saveButton.Location = new System.Drawing.Point(730, 570);
            this.saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);

            // saveAsButton
            this.saveAsButton.Location = new System.Drawing.Point(810, 570);
            this.saveAsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(75, 23);
            this.saveAsButton.TabIndex = 13;
            this.saveAsButton.Text = "Save As";
            this.saveAsButton.UseVisualStyleBackColor = true;
            this.saveAsButton.Click += new System.EventHandler(this.SaveAsButton_Click);
            // 
            // addStringToItemNameButton
            // 
            this.addStringToItemNameButton.Location = new System.Drawing.Point(12, 545);
            this.addStringToItemNameButton.Name = "addStringToItemNameButton";
            this.addStringToItemNameButton.Size = new System.Drawing.Size(90, 23);
            this.addStringToItemNameButton.TabIndex = 18;
            this.addStringToItemNameButton.Text = "Add Item";
            this.addStringToItemNameButton.UseVisualStyleBackColor = true;
            this.addStringToItemNameButton.Click += new System.EventHandler(this.AddStringToItemNameButton_Click);
            // 
            // removeItemNameButton
            // 
            this.removeItemNameButton.Location = new System.Drawing.Point(120, 545);
            this.removeItemNameButton.Name = "removeItemNameButton";
            this.removeItemNameButton.Size = new System.Drawing.Size(90, 23);
            this.removeItemNameButton.TabIndex = 15;
            this.removeItemNameButton.Text = "Remove Item";
            this.removeItemNameButton.UseVisualStyleBackColor = true;
            this.removeItemNameButton.Click += new System.EventHandler(this.RemoveItemNameButton_Click);
            // 
            // addItemButton
            // 
            this.addItemNameButton.Location = new System.Drawing.Point(12, 570);
            this.addItemNameButton.Name = "addItemNameButton";
            this.addItemNameButton.Size = new System.Drawing.Size(75, 23);
            this.addItemNameButton.TabIndex = 14;
            this.addItemNameButton.Text = "Add Group";
            this.addItemNameButton.UseVisualStyleBackColor = true;
            this.addItemNameButton.Click += new System.EventHandler(this.AddItemNameButton_Click);
            // 
            // addRepaintButton
            // 
            this.addRepaintButton.Location = new System.Drawing.Point(218, 545);
            this.addRepaintButton.Name = "addRepaintButton";
            this.addRepaintButton.Size = new System.Drawing.Size(100, 23);
            this.addRepaintButton.TabIndex = 16;
            this.addRepaintButton.Text = "Add Skin";
            this.addRepaintButton.UseVisualStyleBackColor = true;
            this.addRepaintButton.Click += new System.EventHandler(this.AddRepaintButton_Click);
            // 
            // removeRepaintButton
            // 
            this.removeRepaintButton.Location = new System.Drawing.Point(320, 545);
            this.removeRepaintButton.Name = "removeRepaintButton";
            this.removeRepaintButton.Size = new System.Drawing.Size(100, 23);
            this.removeRepaintButton.TabIndex = 17;
            this.removeRepaintButton.Text = "Remove Skin";
            this.removeRepaintButton.UseVisualStyleBackColor = true;
            this.removeRepaintButton.Click += new System.EventHandler(this.RemoveRepaintButton_Click);
            // 
            // labelItemNames
            // 
            this.labelItemNames.AutoSize = true;
            this.labelItemNames.Location = new System.Drawing.Point(12, 12);
            this.labelItemNames.Name = "labelItemNames";
            this.labelItemNames.Size = new System.Drawing.Size(64, 13);
            this.labelItemNames.TabIndex = 19;
            this.labelItemNames.Text = "Item Names";
            // 
            // labelRepaints
            // 
            this.labelRepaints.AutoSize = true;
            this.labelRepaints.Location = new System.Drawing.Point(215, 12);
            this.labelRepaints.Name = "labelRepaints";
            this.labelRepaints.Size = new System.Drawing.Size(49, 13);
            this.labelRepaints.TabIndex = 20;
            this.labelRepaints.Text = "Repaints";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(421, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 21;
            this.labelName.Text = "Name";
            // 
            // labelOverwrittenDisplayName
            // 
            this.labelOverwrittenDisplayName.AutoSize = true;
            this.labelOverwrittenDisplayName.Location = new System.Drawing.Point(421, 51);
            this.labelOverwrittenDisplayName.Name = "labelOverwrittenDisplayName";
            this.labelOverwrittenDisplayName.Size = new System.Drawing.Size(128, 13);
            this.labelOverwrittenDisplayName.TabIndex = 22;
            this.labelOverwrittenDisplayName.Text = "Overwritten Display Name";
            // 
            // labelHiddenSelectionTextures
            // 
            this.labelHiddenSelectionTextures.AutoSize = true;
            this.labelHiddenSelectionTextures.Location = new System.Drawing.Point(421, 90);
            this.labelHiddenSelectionTextures.Name = "labelHiddenSelectionTextures";
            this.labelHiddenSelectionTextures.Size = new System.Drawing.Size(128, 13);
            this.labelHiddenSelectionTextures.TabIndex = 23;
            this.labelHiddenSelectionTextures.Text = "Hidden Selection Textures";
            // 
            // labelHiddenSelectionMaterials
            // 
            this.labelHiddenSelectionMaterials.AutoSize = true;
            this.labelHiddenSelectionMaterials.Location = new System.Drawing.Point(421, 170);
            this.labelHiddenSelectionMaterials.Name = "labelHiddenSelectionMaterials";
            this.labelHiddenSelectionMaterials.Size = new System.Drawing.Size(133, 13);
            this.labelHiddenSelectionMaterials.TabIndex = 24;
            this.labelHiddenSelectionMaterials.Text = "Hidden Selection Materials";
            // 
            // labelPermissionGroups
            // 
            this.labelPermissionGroups.AutoSize = true;
            this.labelPermissionGroups.Location = new System.Drawing.Point(421, 250);
            this.labelPermissionGroups.Name = "labelPermissionGroups";
            this.labelPermissionGroups.Size = new System.Drawing.Size(95, 13);
            this.labelPermissionGroups.TabIndex = 25;
            this.labelPermissionGroups.Text = "Permission Groups";
            // 
            // labelAttachmentItemNames
            // 
            this.labelAttachmentItemNames.AutoSize = true;
            this.labelAttachmentItemNames.Location = new System.Drawing.Point(421, 330);
            this.labelAttachmentItemNames.Name = "labelAttachmentItemNames";
            this.labelAttachmentItemNames.Size = new System.Drawing.Size(128, 13);
            this.labelAttachmentItemNames.TabIndex = 26;
            this.labelAttachmentItemNames.Text = "Attachment Item Names";
            // 
            // labelAttachmentHiddenSelectionTextures
            // 
            this.labelAttachmentHiddenSelectionTextures.AutoSize = true;
            this.labelAttachmentHiddenSelectionTextures.Location = new System.Drawing.Point(421, 410);
            this.labelAttachmentHiddenSelectionTextures.Name = "labelAttachmentHiddenSelectionTextures";
            this.labelAttachmentHiddenSelectionTextures.Size = new System.Drawing.Size(167, 13);
            this.labelAttachmentHiddenSelectionTextures.TabIndex = 27;
            this.labelAttachmentHiddenSelectionTextures.Text = "Attachment Hidden Selection Textures";
            // 
            // labelAttachmentHiddenSelectionMaterials
            // 
            this.labelAttachmentHiddenSelectionMaterials.AutoSize = true;
            this.labelAttachmentHiddenSelectionMaterials.Location = new System.Drawing.Point(421, 490);
            this.labelAttachmentHiddenSelectionMaterials.Name = "labelAttachmentHiddenSelectionMaterials";
            this.labelAttachmentHiddenSelectionMaterials.Size = new System.Drawing.Size(172, 13);
            this.labelAttachmentHiddenSelectionMaterials.TabIndex = 28;
            this.labelAttachmentHiddenSelectionMaterials.Text = "Attachment Hidden Selection Materials";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.labelAttachmentHiddenSelectionMaterials);
            this.Controls.Add(this.labelAttachmentHiddenSelectionTextures);
            this.Controls.Add(this.labelAttachmentItemNames);
            this.Controls.Add(this.labelPermissionGroups);
            this.Controls.Add(this.labelHiddenSelectionMaterials);
            this.Controls.Add(this.labelHiddenSelectionTextures);
            this.Controls.Add(this.labelOverwrittenDisplayName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelRepaints);
            this.Controls.Add(this.labelItemNames);
            this.Controls.Add(this.addStringToItemNameButton);
            this.Controls.Add(this.removeRepaintButton);
            this.Controls.Add(this.addRepaintButton);
            this.Controls.Add(this.removeItemNameButton);
            this.Controls.Add(this.addItemNameButton);
            this.Controls.Add(this.saveAsButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.textBoxAttachmentHiddenSelectionMaterials);
            this.Controls.Add(this.textBoxAttachmentHiddenSelectionTextures);
            this.Controls.Add(this.textBoxAttachmentItemNames);
            this.Controls.Add(this.textBoxPermissionGroups);
            this.Controls.Add(this.textBoxHiddenSelectionMaterials);
            this.Controls.Add(this.textBoxHiddenSelectionTextures);
            this.Controls.Add(this.textBoxOverwrittenDisplayName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.listBoxRepaints);
            this.Controls.Add(this.listBoxItemNames);
            this.Name = "MainForm";
            this.Text = "JSON Editor";
            this.BackColor = System.Drawing.Color.LightGray;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

