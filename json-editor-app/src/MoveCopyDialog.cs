using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace json_editor_app
{
    public partial class MoveCopyDialog : Form
    {
        public string SelectedItemName { get; private set; }
        public bool IsMove { get; private set; }

        public MoveCopyDialog(List<string> itemNames)
        {
            InitializeComponent();
            comboBoxItemNames.DataSource = itemNames;
        }

        private void InitializeComponent()
        {
            this.comboBoxItemNames = new System.Windows.Forms.ComboBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxItemNames
            // 
            this.comboBoxItemNames.FormattingEnabled = true;
            this.comboBoxItemNames.Location = new System.Drawing.Point(12, 12);
            this.comboBoxItemNames.Name = "comboBoxItemNames";
            this.comboBoxItemNames.Size = new System.Drawing.Size(260, 21);
            this.comboBoxItemNames.TabIndex = 0;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(116, 39);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(197, 39);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // MoveCopyDialog
            // 
            this.ClientSize = new System.Drawing.Size(284, 71);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.comboBoxItemNames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MoveCopyDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Target Item";
            this.ResumeLayout(false);

        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            SelectedItemName = comboBoxItemNames.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private System.Windows.Forms.ComboBox comboBoxItemNames;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}
