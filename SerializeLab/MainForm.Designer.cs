namespace SerializeLab
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListBoxAutos = new System.Windows.Forms.ListBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.PanelAdding = new System.Windows.Forms.Panel();
            this.ComboBoxInput = new System.Windows.Forms.ComboBox();
            this.PanelEditing = new System.Windows.Forms.Panel();
            this.ButtonSubmitEdit = new System.Windows.Forms.Button();
            this.OpenSerializeFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveSerializeFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MenuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuMain
            // 
            this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MenuMain.Location = new System.Drawing.Point(0, 0);
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Size = new System.Drawing.Size(748, 24);
            this.MenuMain.TabIndex = 1;
            this.MenuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem,
            this.deserializeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.serializeToolStripMenuItem.Text = "Serialize";
            this.serializeToolStripMenuItem.Click += new System.EventHandler(this.serializeToolStripMenuItem_Click);
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deserializeToolStripMenuItem.Text = "Deserialize";
            this.deserializeToolStripMenuItem.Click += new System.EventHandler(this.deserializeToolStripMenuItem_Click);
            // 
            // ListBoxAutos
            // 
            this.ListBoxAutos.FormattingEnabled = true;
            this.ListBoxAutos.Location = new System.Drawing.Point(494, 32);
            this.ListBoxAutos.Name = "ListBoxAutos";
            this.ListBoxAutos.Size = new System.Drawing.Size(244, 329);
            this.ListBoxAutos.TabIndex = 2;
            this.ListBoxAutos.SelectedIndexChanged += new System.EventHandler(this.ListBoxAutos_SelectedIndexChanged);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(12, 367);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(81, 25);
            this.ButtonAdd.TabIndex = 3;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(494, 368);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(81, 25);
            this.ButtonDelete.TabIndex = 4;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // PanelAdding
            // 
            this.PanelAdding.AutoScroll = true;
            this.PanelAdding.Location = new System.Drawing.Point(12, 54);
            this.PanelAdding.Name = "PanelAdding";
            this.PanelAdding.Size = new System.Drawing.Size(230, 307);
            this.PanelAdding.TabIndex = 7;
            // 
            // ComboBoxInput
            // 
            this.ComboBoxInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxInput.FormattingEnabled = true;
            this.ComboBoxInput.Items.AddRange(new object[] {
            "CarWithClosedRoof",
            "CarrWithOpenedRoof",
            "Lorry",
            "Truck",
            "Bus",
            "TrolleyBus"});
            this.ComboBoxInput.Location = new System.Drawing.Point(12, 32);
            this.ComboBoxInput.Name = "ComboBoxInput";
            this.ComboBoxInput.Size = new System.Drawing.Size(229, 21);
            this.ComboBoxInput.TabIndex = 8;
            this.ComboBoxInput.SelectedIndexChanged += new System.EventHandler(this.ComboBoxInput_SelectedIndexChanged);
            // 
            // PanelEditing
            // 
            this.PanelEditing.AutoScroll = true;
            this.PanelEditing.Location = new System.Drawing.Point(248, 32);
            this.PanelEditing.Name = "PanelEditing";
            this.PanelEditing.Size = new System.Drawing.Size(240, 329);
            this.PanelEditing.TabIndex = 9;
            // 
            // ButtonSubmitEdit
            // 
            this.ButtonSubmitEdit.Location = new System.Drawing.Point(248, 368);
            this.ButtonSubmitEdit.Name = "ButtonSubmitEdit";
            this.ButtonSubmitEdit.Size = new System.Drawing.Size(75, 23);
            this.ButtonSubmitEdit.TabIndex = 10;
            this.ButtonSubmitEdit.Text = "SubmitEdit";
            this.ButtonSubmitEdit.UseVisualStyleBackColor = true;
            this.ButtonSubmitEdit.Click += new System.EventHandler(this.ButtonSubmitEdit_Click);
            // 
            // OpenSerializeFileDialog
            // 
            this.OpenSerializeFileDialog.Filter = "Text files(*.txt)|*.txt";
            // 
            // SaveSerializeFileDialog
            // 
            this.SaveSerializeFileDialog.DefaultExt = "txt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 400);
            this.Controls.Add(this.ButtonSubmitEdit);
            this.Controls.Add(this.PanelEditing);
            this.Controls.Add(this.ComboBoxInput);
            this.Controls.Add(this.PanelAdding);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ListBoxAutos);
            this.Controls.Add(this.MenuMain);
            this.MainMenuStrip = this.MenuMain;
            this.Name = "MainForm";
            this.Text = "SerializeLab";
            this.MenuMain.ResumeLayout(false);
            this.MenuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeToolStripMenuItem;
        private System.Windows.Forms.ListBox ListBoxAutos;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Panel PanelAdding;
        private System.Windows.Forms.ComboBox ComboBoxInput;
        private System.Windows.Forms.Panel PanelEditing;
        private System.Windows.Forms.Button ButtonSubmitEdit;
        private System.Windows.Forms.OpenFileDialog OpenSerializeFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveSerializeFileDialog;
    }
}

