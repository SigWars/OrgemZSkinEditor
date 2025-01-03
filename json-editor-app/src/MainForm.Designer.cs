﻿using System.Windows.Forms;

namespace json_editor_app
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxItemNames;
        private System.Windows.Forms.ListBox listBoxRepaints;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxOverwrittenDisplayName;
        private System.Windows.Forms.TextBox textBoxExcludedItems; // Adicionado campo textBoxExcludedItems
        private System.Windows.Forms.TextBox textBoxHiddenSelectionTextures;
        private System.Windows.Forms.TextBox textBoxHiddenSelectionMaterials;
        private System.Windows.Forms.TextBox textBoxPermissionGroups;
        private System.Windows.Forms.TextBox textBoxAttachmentItemNames;
        private System.Windows.Forms.TextBox textBoxAttachmentHiddenSelectionTextures;
        private System.Windows.Forms.TextBox textBoxAttachmentHiddenSelectionMaterials;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button loadHiddenSelectionTextButton;
        private System.Windows.Forms.Button loadHiddenSelectionMaterialsButton; // Adicionado botão para textBoxHiddenSelectionMaterials
        private System.Windows.Forms.Button loadAttachmentHiddenSelectionTexturesButton; // Adicionado botão para textBoxAttachmentHiddenSelectionTextures
        private System.Windows.Forms.Button loadAttachmentHiddenSelectionMaterialsButton; // Adicionado botão para textBoxAttachmentHiddenSelectionMaterials
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button saveAsButton;
        private System.Windows.Forms.Button addItemNameButton;
        private System.Windows.Forms.Button removeItemNameButton;
        private System.Windows.Forms.Button addRepaintButton;
        private System.Windows.Forms.Button removeRepaintButton;
        private System.Windows.Forms.Button addStringToItemNameButton;
        private System.Windows.Forms.Button renameRepaintButton;
        private System.Windows.Forms.Button renameItemNameButton; // Adicionado botão de renomear
        private System.Windows.Forms.Button moveRepaintButton; // Adicionado botão de mover
        private System.Windows.Forms.Button copyRepaintButton; // Adicionado botão de copiar
        private System.Windows.Forms.Button saveFinalVersionButton; // Adicionado botão de salvar versão final
        private System.Windows.Forms.Button moveItemButton; // Adicionado botão de mover item
        private System.Windows.Forms.Button copyItemButton; // Adicionado botão de copiar item
        private System.Windows.Forms.Button moveItemUpButton; // Adicionado botão de mover item para cima
        private System.Windows.Forms.Button moveItemDownButton; // Adicionado botão de mover item para baixo
        private System.Windows.Forms.Button moveRepaintUpButton; // Adicionado botão de mover repaint para cima
        private System.Windows.Forms.Button moveRepaintDownButton; // Adicionado botão de mover repaint para baixo
        private System.Windows.Forms.Label labelItemNames;
        private System.Windows.Forms.Label labelRepaints;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelOverwrittenDisplayName;
        private System.Windows.Forms.Label labelExcludedItems; // Adicionado label para textBoxExcludedItems
        private System.Windows.Forms.Label labelHiddenSelectionTextures;
        private System.Windows.Forms.Label labelHiddenSelectionMaterials;
        private System.Windows.Forms.Label labelPermissionGroups;
        private System.Windows.Forms.Label labelAttachmentItemNames;
        private System.Windows.Forms.Label labelAttachmentHiddenSelectionTextures;
        private System.Windows.Forms.Label labelAttachmentHiddenSelectionMaterials;
        private System.Windows.Forms.ComboBox comboBoxItemNames; // Adicionado ComboBox

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
            this.textBoxExcludedItems = new System.Windows.Forms.TextBox(); // Adicionado campo textBoxExcludedItems
            this.textBoxHiddenSelectionTextures = new System.Windows.Forms.TextBox();
            this.textBoxHiddenSelectionMaterials = new System.Windows.Forms.TextBox();
            this.textBoxPermissionGroups = new System.Windows.Forms.TextBox();
            this.textBoxAttachmentItemNames = new System.Windows.Forms.TextBox();
            this.textBoxAttachmentHiddenSelectionTextures = new System.Windows.Forms.TextBox();
            this.textBoxAttachmentHiddenSelectionMaterials = new System.Windows.Forms.TextBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.loadHiddenSelectionTextButton = new System.Windows.Forms.Button();
            this.loadHiddenSelectionMaterialsButton = new System.Windows.Forms.Button(); // Adicionado botão para textBoxHiddenSelectionMaterials
            this.loadAttachmentHiddenSelectionTexturesButton = new System.Windows.Forms.Button(); // Adicionado botão para textBoxAttachmentHiddenSelectionTextures
            this.loadAttachmentHiddenSelectionMaterialsButton = new System.Windows.Forms.Button(); // Adicionado botão para textBoxAttachmentHiddenSelectionMaterials
            this.saveButton = new System.Windows.Forms.Button();
            this.saveAsButton = new System.Windows.Forms.Button();
            this.addItemNameButton = new System.Windows.Forms.Button();
            this.removeItemNameButton = new System.Windows.Forms.Button();
            this.addRepaintButton = new System.Windows.Forms.Button();
            this.removeRepaintButton = new System.Windows.Forms.Button();
            this.addStringToItemNameButton = new System.Windows.Forms.Button();
            this.renameItemNameButton = new System.Windows.Forms.Button();
            this.renameRepaintButton = new System.Windows.Forms.Button(); // Adicionado botão de renomear
            this.moveRepaintButton = new System.Windows.Forms.Button(); // Adicionado botão de mover
            this.copyRepaintButton = new System.Windows.Forms.Button(); // Adicionado botão de copiar
            this.saveFinalVersionButton = new System.Windows.Forms.Button(); // Adicionado botão de salvar versão final
            this.moveItemButton = new System.Windows.Forms.Button(); // Adicionado botão de mover item
            this.copyItemButton = new System.Windows.Forms.Button(); // Adicionado botão de copiar item
            this.moveItemUpButton = new System.Windows.Forms.Button(); // Adicionado botão de mover item para cima
            this.moveItemDownButton = new System.Windows.Forms.Button(); // Adicionado botão de mover item para baixo
            this.moveRepaintUpButton = new System.Windows.Forms.Button(); // Adicionado botão de mover repaint para cima
            this.moveRepaintDownButton = new System.Windows.Forms.Button(); // Adicionado botão de mover repaint para baixo
            this.labelItemNames = new System.Windows.Forms.Label();
            this.labelRepaints = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelOverwrittenDisplayName = new System.Windows.Forms.Label();
            this.labelExcludedItems = new System.Windows.Forms.Label(); // Adicionado label para textBoxExcludedItems
            this.labelHiddenSelectionTextures = new System.Windows.Forms.Label();
            this.labelHiddenSelectionMaterials = new System.Windows.Forms.Label();
            this.labelPermissionGroups = new System.Windows.Forms.Label();
            this.labelAttachmentItemNames = new System.Windows.Forms.Label();
            this.labelAttachmentHiddenSelectionTextures = new System.Windows.Forms.Label();
            this.labelAttachmentHiddenSelectionMaterials = new System.Windows.Forms.Label();
            this.comboBoxItemNames = new System.Windows.Forms.ComboBox(); // Adicionado ComboBox
            this.SuspendLayout();
            // 
            // comboBoxItemNames
            // 
            this.comboBoxItemNames.FormattingEnabled = true;
            this.comboBoxItemNames.Location = new System.Drawing.Point(12, 12);
            this.comboBoxItemNames.Name = "comboBoxItemNames";
            this.comboBoxItemNames.Size = new System.Drawing.Size(200, 21);
            this.comboBoxItemNames.TabIndex = 29;
            this.comboBoxItemNames.SelectedIndexChanged += new System.EventHandler(this.ComboBoxItemNames_SelectedIndexChanged);
            // 
            // listBoxItemNames
            // 
            this.listBoxItemNames.FormattingEnabled = true;
            this.listBoxItemNames.Location = new System.Drawing.Point(12, 50);
            this.listBoxItemNames.Name = "listBoxItemNames";
            this.listBoxItemNames.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended; // Permitir múltiplas seleções
            this.listBoxItemNames.Size = new System.Drawing.Size(200, 498);
            this.listBoxItemNames.TabIndex = 0;
            this.listBoxItemNames.SelectedIndexChanged += new System.EventHandler(this.ListBoxItemNames_SelectedIndexChanged);
            // 
            // listBoxRepaints
            // 
            this.listBoxRepaints.FormattingEnabled = true;
            this.listBoxRepaints.Location = new System.Drawing.Point(218, 28);
            this.listBoxRepaints.Name = "listBoxRepaints";
            this.listBoxRepaints.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended; // Permitir múltiplas seleções
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
            // textBoxExcludedItems
            // 
            this.textBoxExcludedItems.Location = new System.Drawing.Point(424, 106);
            this.textBoxExcludedItems.Multiline = true;
            this.textBoxExcludedItems.Name = "textBoxExcludedItems";
            this.textBoxExcludedItems.Size = new System.Drawing.Size(364, 60);
            this.textBoxExcludedItems.TabIndex = 4;
            // 
            // textBoxHiddenSelectionTextures
            // 
            this.textBoxHiddenSelectionTextures.Location = new System.Drawing.Point(424, 186);
            this.textBoxHiddenSelectionTextures.Multiline = true;
            this.textBoxHiddenSelectionTextures.Name = "textBoxHiddenSelectionTextures";
            this.textBoxHiddenSelectionTextures.Size = new System.Drawing.Size(500, 60);
            this.textBoxHiddenSelectionTextures.TabIndex = 5;
            // 
            // loadHiddenSelectionTextButton
            // 
            this.loadHiddenSelectionTextButton = new System.Windows.Forms.Button();
            this.loadHiddenSelectionTextButton.Location = new System.Drawing.Point(875, 162); // Ajuste a posição conforme necessário
            this.loadHiddenSelectionTextButton.Name = "loadHiddenSelectionTextButton";
            this.loadHiddenSelectionTextButton.Size = new System.Drawing.Size(50, 23);
            this.loadHiddenSelectionTextButton.TabIndex = 40;
            this.loadHiddenSelectionTextButton.Text = "Load";
            this.loadHiddenSelectionTextButton.UseVisualStyleBackColor = true;
            this.loadHiddenSelectionTextButton.Click += new System.EventHandler(this.LoadHiddenSelectionTextButton_Click);
            // 
            // textBoxHiddenSelectionMaterials
            // 
            this.textBoxHiddenSelectionMaterials.Location = new System.Drawing.Point(424, 266);
            this.textBoxHiddenSelectionMaterials.Multiline = true;
            this.textBoxHiddenSelectionMaterials.Name = "textBoxHiddenSelectionMaterials";
            this.textBoxHiddenSelectionMaterials.Size = new System.Drawing.Size(500, 60);
            this.textBoxHiddenSelectionMaterials.TabIndex = 6;
            // 
            // loadHiddenSelectionMaterialsButton
            // 
            this.loadHiddenSelectionMaterialsButton = new System.Windows.Forms.Button();
            this.loadHiddenSelectionMaterialsButton.Location = new System.Drawing.Point(875, 242); // Ajuste a posição conforme necessário
            this.loadHiddenSelectionMaterialsButton.Name = "loadHiddenSelectionMaterialsButton";
            this.loadHiddenSelectionMaterialsButton.Size = new System.Drawing.Size(50, 23);
            this.loadHiddenSelectionMaterialsButton.TabIndex = 41;
            this.loadHiddenSelectionMaterialsButton.Text = "Load";
            this.loadHiddenSelectionMaterialsButton.UseVisualStyleBackColor = true;
            this.loadHiddenSelectionMaterialsButton.Click += new System.EventHandler(this.LoadHiddenSelectionMaterialsButton_Click);
            // 
            // textBoxPermissionGroups
            // 
            this.textBoxPermissionGroups.Location = new System.Drawing.Point(424, 346);
            this.textBoxPermissionGroups.Multiline = true;
            this.textBoxPermissionGroups.Name = "textBoxPermissionGroups";
            this.textBoxPermissionGroups.Size = new System.Drawing.Size(364, 60);
            this.textBoxPermissionGroups.TabIndex = 7;
            // 
            // textBoxAttachmentItemNames
            // 
            this.textBoxAttachmentItemNames.Location = new System.Drawing.Point(424, 426);
            this.textBoxAttachmentItemNames.Multiline = true;
            this.textBoxAttachmentItemNames.Name = "textBoxAttachmentItemNames";
            this.textBoxAttachmentItemNames.Size = new System.Drawing.Size(364, 60);
            this.textBoxAttachmentItemNames.TabIndex = 8;
            // 
            // textBoxAttachmentHiddenSelectionTextures
            // 
            this.textBoxAttachmentHiddenSelectionTextures.Location = new System.Drawing.Point(424, 506);
            this.textBoxAttachmentHiddenSelectionTextures.Multiline = true;
            this.textBoxAttachmentHiddenSelectionTextures.Name = "textBoxAttachmentHiddenSelectionTextures";
            this.textBoxAttachmentHiddenSelectionTextures.Size = new System.Drawing.Size(500, 60);
            this.textBoxAttachmentHiddenSelectionTextures.TabIndex = 9;
            // 
            // loadAttachmentHiddenSelectionTexturesButton
            // 
            this.loadAttachmentHiddenSelectionTexturesButton = new System.Windows.Forms.Button();
            this.loadAttachmentHiddenSelectionTexturesButton.Location = new System.Drawing.Point(875, 482); // Ajuste a posição conforme necessário
            this.loadAttachmentHiddenSelectionTexturesButton.Name = "loadAttachmentHiddenSelectionTexturesButton";
            this.loadAttachmentHiddenSelectionTexturesButton.Size = new System.Drawing.Size(50, 23);
            this.loadAttachmentHiddenSelectionTexturesButton.TabIndex = 42;
            this.loadAttachmentHiddenSelectionTexturesButton.Text = "Load";
            this.loadAttachmentHiddenSelectionTexturesButton.UseVisualStyleBackColor = true;
            this.loadAttachmentHiddenSelectionTexturesButton.Click += new System.EventHandler(this.LoadAttachmentHiddenSelectionTexturesButton_Click);
            // 
            // textBoxAttachmentHiddenSelectionMaterials
            // 
            this.textBoxAttachmentHiddenSelectionMaterials.Location = new System.Drawing.Point(424, 586);
            this.textBoxAttachmentHiddenSelectionMaterials.Multiline = true;
            this.textBoxAttachmentHiddenSelectionMaterials.Name = "textBoxAttachmentHiddenSelectionMaterials";
            this.textBoxAttachmentHiddenSelectionMaterials.Size = new System.Drawing.Size(500, 60);
            this.textBoxAttachmentHiddenSelectionMaterials.TabIndex = 10;
            // 
            // loadAttachmentHiddenSelectionMaterialsButton
            // 
            this.loadAttachmentHiddenSelectionMaterialsButton = new System.Windows.Forms.Button();
            this.loadAttachmentHiddenSelectionMaterialsButton.Location = new System.Drawing.Point(875, 562); // Ajuste a posição conforme necessário
            this.loadAttachmentHiddenSelectionMaterialsButton.Name = "loadAttachmentHiddenSelectionMaterialsButton";
            this.loadAttachmentHiddenSelectionMaterialsButton.Size = new System.Drawing.Size(50, 23);
            this.loadAttachmentHiddenSelectionMaterialsButton.TabIndex = 43;
            this.loadAttachmentHiddenSelectionMaterialsButton.Text = "Load";
            this.loadAttachmentHiddenSelectionMaterialsButton.UseVisualStyleBackColor = true;
            this.loadAttachmentHiddenSelectionMaterialsButton.Click += new System.EventHandler(this.LoadAttachmentHiddenSelectionMaterialsButton_Click);
            // 
            // renameRepaintButton
            //
            this.renameRepaintButton = new System.Windows.Forms.Button();
            this.renameRepaintButton.Location = new System.Drawing.Point(218, 630); // Ajuste a posição conforme necessário
            this.renameRepaintButton.Name = "renameRepaintButton";
            this.renameRepaintButton.Size = new System.Drawing.Size(100, 23);
            this.renameRepaintButton.TabIndex = 10;
            this.renameRepaintButton.Text = "Rename Skin";
            this.renameRepaintButton.UseVisualStyleBackColor = true;
            this.renameRepaintButton.Click += new System.EventHandler(this.RenameRepaintButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(650, 660);
            this.loadButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 11;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(730, 660);
            this.saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // saveAsButton
            // 
            this.saveAsButton.Location = new System.Drawing.Point(810, 660);
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
            this.addItemNameButton.Size = new System.Drawing.Size(90, 23);
            this.addItemNameButton.TabIndex = 14;
            this.addItemNameButton.Text = "Add Group";
            this.addItemNameButton.UseVisualStyleBackColor = true;
            this.addItemNameButton.Click += new System.EventHandler(this.AddItemNameButton_Click);
            // 
            // renameItemNameButton
            // 
            this.renameItemNameButton.Location = new System.Drawing.Point(120, 570);
            this.renameItemNameButton.Name = "renameItemNameButton";
            this.renameItemNameButton.Size = new System.Drawing.Size(90, 23);
            this.renameItemNameButton.TabIndex = 33;
            this.renameItemNameButton.Text = "Rename Item";
            this.renameItemNameButton.UseVisualStyleBackColor = true;
            this.renameItemNameButton.Click += new System.EventHandler(this.RenameItemNameButton_Click);
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
            // moveRepaintButton
            // 
            this.moveRepaintButton.Location = new System.Drawing.Point(218, 570);
            this.moveRepaintButton.Name = "moveRepaintButton";
            this.moveRepaintButton.Size = new System.Drawing.Size(100, 23);
            this.moveRepaintButton.TabIndex = 30;
            this.moveRepaintButton.Text = "Move Skin";
            this.moveRepaintButton.UseVisualStyleBackColor = true;
            this.moveRepaintButton.Click += new System.EventHandler(this.MoveRepaintButton_Click);
            // 
            // copyRepaintButton
            // 
            this.copyRepaintButton.Location = new System.Drawing.Point(320, 570);
            this.copyRepaintButton.Name = "copyRepaintButton";
            this.copyRepaintButton.Size = new System.Drawing.Size(100, 23);
            this.copyRepaintButton.TabIndex = 31;
            this.copyRepaintButton.Text = "Copy Skin";
            this.copyRepaintButton.UseVisualStyleBackColor = true;
            this.copyRepaintButton.Click += new System.EventHandler(this.CopyRepaintButton_Click);
            // 
            // saveFinalVersionButton
            // 
            this.saveFinalVersionButton.Location = new System.Drawing.Point(430, 660);
            this.saveFinalVersionButton.Name = "saveFinalVersionButton";
            this.saveFinalVersionButton.Size = new System.Drawing.Size(100, 23);
            this.saveFinalVersionButton.TabIndex = 32;
            this.saveFinalVersionButton.Text = "Save Final Version";
            this.saveFinalVersionButton.UseVisualStyleBackColor = true;
            this.saveFinalVersionButton.Click += new System.EventHandler(this.SaveFinalVersionButton_Click);
            // 
            // moveItemButton
            // 
            this.moveItemButton.Location = new System.Drawing.Point(12, 600);
            this.moveItemButton.Name = "moveItemButton";
            this.moveItemButton.Size = new System.Drawing.Size(90, 23);
            this.moveItemButton.TabIndex = 34;
            this.moveItemButton.Text = "Mover Item";
            this.moveItemButton.UseVisualStyleBackColor = true;
            this.moveItemButton.Click += new System.EventHandler(this.MoveItemButton_Click);
            // 
            // copyItemButton
            // 
            this.copyItemButton.Location = new System.Drawing.Point(120, 600);
            this.copyItemButton.Name = "copyItemButton";
            this.copyItemButton.Size = new System.Drawing.Size(90, 23);
            this.copyItemButton.TabIndex = 35;
            this.copyItemButton.Text = "Copiar Item";
            this.copyItemButton.UseVisualStyleBackColor = true;
            this.copyItemButton.Click += new System.EventHandler(this.CopyItemButton_Click);
            // 
            // moveItemUpButton
            // 
            this.moveItemUpButton.Location = new System.Drawing.Point(12, 630);
            this.moveItemUpButton.Name = "moveItemUpButton";
            this.moveItemUpButton.Size = new System.Drawing.Size(90, 23);
            this.moveItemUpButton.TabIndex = 36;
            this.moveItemUpButton.Text = "Mover Item ↑";
            this.moveItemUpButton.UseVisualStyleBackColor = true;
            this.moveItemUpButton.Click += new System.EventHandler(this.MoveItemUpButton_Click);
            // 
            // moveItemDownButton
            // 
            this.moveItemDownButton.Location = new System.Drawing.Point(120, 630);
            this.moveItemDownButton.Name = "moveItemDownButton";
            this.moveItemDownButton.Size = new System.Drawing.Size(90, 23);
            this.moveItemDownButton.TabIndex = 37;
            this.moveItemDownButton.Text = "Mover Item ↓";
            this.moveItemDownButton.UseVisualStyleBackColor = true;
            this.moveItemDownButton.Click += new System.EventHandler(this.MoveItemDownButton_Click);
            // 
            // moveRepaintUpButton
            // 
            this.moveRepaintUpButton.Location = new System.Drawing.Point(218, 600);
            this.moveRepaintUpButton.Name = "moveRepaintUpButton";
            this.moveRepaintUpButton.Size = new System.Drawing.Size(100, 23);
            this.moveRepaintUpButton.TabIndex = 38;
            this.moveRepaintUpButton.Text = "Mover Skin ↑";
            this.moveRepaintUpButton.UseVisualStyleBackColor = true;
            this.moveRepaintUpButton.Click += new System.EventHandler(this.MoveRepaintUpButton_Click);
            // 
            // moveRepaintDownButton
            // 
            this.moveRepaintDownButton.Location = new System.Drawing.Point(320, 600);
            this.moveRepaintDownButton.Name = "moveRepaintDownButton";
            this.moveRepaintDownButton.Size = new System.Drawing.Size(100, 23);
            this.moveRepaintDownButton.TabIndex = 39;
            this.moveRepaintDownButton.Text = "Mover Skin ↓";
            this.moveRepaintDownButton.UseVisualStyleBackColor = true;
            this.moveRepaintDownButton.Click += new System.EventHandler(this.MoveRepaintDownButton_Click);
            // 
            // labelItemNames
            // 
            this.labelItemNames.AutoSize = true;
            this.labelItemNames.Location = new System.Drawing.Point(12, 34);
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
            // labelExcludedItems
            // 
            this.labelExcludedItems.AutoSize = true;
            this.labelExcludedItems.Location = new System.Drawing.Point(421, 90);
            this.labelExcludedItems.Name = "labelExcludedItems";
            this.labelExcludedItems.Size = new System.Drawing.Size(80, 13);
            this.labelExcludedItems.TabIndex = 23;
            this.labelExcludedItems.Text = "Excluded Items";
            // 
            // labelHiddenSelectionTextures
            // 
            this.labelHiddenSelectionTextures.AutoSize = true;
            this.labelHiddenSelectionTextures.Location = new System.Drawing.Point(421, 170);
            this.labelHiddenSelectionTextures.Name = "labelHiddenSelectionTextures";
            this.labelHiddenSelectionTextures.Size = new System.Drawing.Size(128, 13);
            this.labelHiddenSelectionTextures.TabIndex = 24;
            this.labelHiddenSelectionTextures.Text = "Hidden Selection Textures";
            // 
            // labelHiddenSelectionMaterials
            // 
            this.labelHiddenSelectionMaterials.AutoSize = true;
            this.labelHiddenSelectionMaterials.Location = new System.Drawing.Point(421, 250);
            this.labelHiddenSelectionMaterials.Name = "labelHiddenSelectionMaterials";
            this.labelHiddenSelectionMaterials.Size = new System.Drawing.Size(133, 13);
            this.labelHiddenSelectionMaterials.TabIndex = 25;
            this.labelHiddenSelectionMaterials.Text = "Hidden Selection Materials";
            // 
            // labelPermissionGroups
            // 
            this.labelPermissionGroups.AutoSize = true;
            this.labelPermissionGroups.Location = new System.Drawing.Point(421, 330);
            this.labelPermissionGroups.Name = "labelPermissionGroups";
            this.labelPermissionGroups.Size = new System.Drawing.Size(95, 13);
            this.labelPermissionGroups.TabIndex = 26;
            this.labelPermissionGroups.Text = "Permission Groups";
            // 
            // labelAttachmentItemNames
            // 
            this.labelAttachmentItemNames.AutoSize = true;
            this.labelAttachmentItemNames.Location = new System.Drawing.Point(421, 410);
            this.labelAttachmentItemNames.Name = "labelAttachmentItemNames";
            this.labelAttachmentItemNames.Size = new System.Drawing.Size(128, 13);
            this.labelAttachmentItemNames.TabIndex = 27;
            this.labelAttachmentItemNames.Text = "Attachment Item Names";
            // 
            // labelAttachmentHiddenSelectionTextures
            // 
            this.labelAttachmentHiddenSelectionTextures.AutoSize = true;
            this.labelAttachmentHiddenSelectionTextures.Location = new System.Drawing.Point(421, 490);
            this.labelAttachmentHiddenSelectionTextures.Name = "labelAttachmentHiddenSelectionTextures";
            this.labelAttachmentHiddenSelectionTextures.Size = new System.Drawing.Size(167, 13);
            this.labelAttachmentHiddenSelectionTextures.TabIndex = 28;
            this.labelAttachmentHiddenSelectionTextures.Text = "Attachment Hidden Selection Textures";
            // 
            // labelAttachmentHiddenSelectionMaterials
            // 
            this.labelAttachmentHiddenSelectionMaterials.AutoSize = true;
            this.labelAttachmentHiddenSelectionMaterials.Location = new System.Drawing.Point(421, 570);
            this.labelAttachmentHiddenSelectionMaterials.Name = "labelAttachmentHiddenSelectionMaterials";
            this.labelAttachmentHiddenSelectionMaterials.Size = new System.Drawing.Size(172, 13);
            this.labelAttachmentHiddenSelectionMaterials.TabIndex = 29;
            this.labelAttachmentHiddenSelectionMaterials.Text = "Attachment Hidden Selection Materials";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(950, 700);
            this.Controls.Add(this.moveItemButton); // Adicionado botão de mover item
            this.Controls.Add(this.copyItemButton); // Adicionado botão de copiar item
            this.Controls.Add(this.moveItemUpButton); // Adicionado botão de mover item para cima
            this.Controls.Add(this.moveItemDownButton); // Adicionado botão de mover item para baixo
            this.Controls.Add(this.moveRepaintUpButton); // Adicionado botão de mover repaint para cima
            this.Controls.Add(this.moveRepaintDownButton); // Adicionado botão de mover repaint para baixo
            this.Controls.Add(this.comboBoxItemNames); // Adicionado ComboBox
            this.Controls.Add(this.labelAttachmentHiddenSelectionMaterials);
            this.Controls.Add(this.labelAttachmentHiddenSelectionTextures);
            this.Controls.Add(this.labelAttachmentItemNames);
            this.Controls.Add(this.labelPermissionGroups);
            this.Controls.Add(this.labelHiddenSelectionMaterials);
            this.Controls.Add(this.labelHiddenSelectionTextures);
            this.Controls.Add(this.labelExcludedItems); // Adicionado label para textBoxExcludedItems
            this.Controls.Add(this.labelOverwrittenDisplayName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelRepaints);
            this.Controls.Add(this.labelItemNames);
            this.Controls.Add(this.addStringToItemNameButton);
            this.Controls.Add(this.removeRepaintButton);
            this.Controls.Add(this.addRepaintButton);
            this.Controls.Add(this.removeItemNameButton);
            this.Controls.Add(this.addItemNameButton);
            this.Controls.Add(this.renameItemNameButton); // Adicionado botão de renomear
            this.Controls.Add(this.saveAsButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.loadHiddenSelectionTextButton);
            this.Controls.Add(this.loadHiddenSelectionMaterialsButton); // Adicionado botão para textBoxHiddenSelectionMaterials
            this.Controls.Add(this.loadAttachmentHiddenSelectionTexturesButton); // Adicionado botão para textBoxAttachmentHiddenSelectionTextures
            this.Controls.Add(this.loadAttachmentHiddenSelectionMaterialsButton); // Adicionado botão para textBoxAttachmentHiddenSelectionMaterials
            this.Controls.Add(this.renameRepaintButton);
            this.Controls.Add(this.moveRepaintButton); // Adicionado botão de mover
            this.Controls.Add(this.copyRepaintButton); // Adicionado botão de copiar
            this.Controls.Add(this.saveFinalVersionButton); // Adicionado botão de salvar versão final
            this.Controls.Add(this.textBoxAttachmentHiddenSelectionMaterials);
            this.Controls.Add(this.textBoxAttachmentHiddenSelectionTextures);
            this.Controls.Add(this.textBoxAttachmentItemNames);
            this.Controls.Add(this.textBoxPermissionGroups);
            this.Controls.Add(this.textBoxHiddenSelectionMaterials);
            this.Controls.Add(this.textBoxHiddenSelectionTextures);
            this.Controls.Add(this.textBoxExcludedItems); // Adicionado campo textBoxExcludedItems
            this.Controls.Add(this.textBoxOverwrittenDisplayName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.listBoxRepaints);
            this.Controls.Add(this.listBoxItemNames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Size = new System.Drawing.Size(1024, 750);
            this.Name = "Skin Editor";
            this.Text = "OrigemZ Skin Editor";
            this.BackColor = System.Drawing.Color.LightGray;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
