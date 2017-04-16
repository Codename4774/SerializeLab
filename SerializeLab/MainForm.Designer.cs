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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.CheckedListBoxAutosToAdd = new System.Windows.Forms.CheckedListBox();
            this.PanelFormEditor = new System.Windows.Forms.Panel();
            this.MenuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuMain
            // 
            this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MenuMain.Location = new System.Drawing.Point(0, 0);
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Size = new System.Drawing.Size(759, 24);
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
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.serializeToolStripMenuItem.Text = "Serialize";
            this.serializeToolStripMenuItem.Click += new System.EventHandler(this.serializeToolStripMenuItem_Click);
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.deserializeToolStripMenuItem.Text = "Deserialize";
            // 
            // ListBoxAutos
            // 
            this.ListBoxAutos.FormattingEnabled = true;
            this.ListBoxAutos.Location = new System.Drawing.Point(503, 23);
            this.ListBoxAutos.Name = "ListBoxAutos";
            this.ListBoxAutos.Size = new System.Drawing.Size(244, 238);
            this.ListBoxAutos.TabIndex = 2;
            this.ListBoxAutos.SelectedIndexChanged += new System.EventHandler(this.ListBoxAutos_SelectedIndexChanged);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(503, 367);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(81, 25);
            this.ButtonAdd.TabIndex = 3;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(666, 267);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(81, 25);
            this.ButtonDelete.TabIndex = 4;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 23);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(221, 242);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // CheckedListBoxAutosToAdd
            // 
            this.CheckedListBoxAutosToAdd.CheckOnClick = true;
            this.CheckedListBoxAutosToAdd.FormattingEnabled = true;
            this.CheckedListBoxAutosToAdd.Items.AddRange(new object[] {
            "CarWithClosedRoof",
            "CarrWithOpenedRoof",
            "Lorry",
            "Truck",
            "Bus",
            "TrolleyBus"});
            this.CheckedListBoxAutosToAdd.Location = new System.Drawing.Point(503, 267);
            this.CheckedListBoxAutosToAdd.Name = "CheckedListBoxAutosToAdd";
            this.CheckedListBoxAutosToAdd.Size = new System.Drawing.Size(157, 94);
            this.CheckedListBoxAutosToAdd.TabIndex = 6;
            this.CheckedListBoxAutosToAdd.Click += new System.EventHandler(this.CheckedListBoxAutosToAdd_Click);
            this.CheckedListBoxAutosToAdd.SelectedIndexChanged += new System.EventHandler(this.CheckedListBoxAutosToAdd_SelectedIndexChanged);
            // 
            // PanelFormEditor
            // 
            this.PanelFormEditor.AutoScroll = true;
            this.PanelFormEditor.Location = new System.Drawing.Point(255, 23);
            this.PanelFormEditor.Name = "PanelFormEditor";
            this.PanelFormEditor.Size = new System.Drawing.Size(230, 269);
            this.PanelFormEditor.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 424);
            this.Controls.Add(this.PanelFormEditor);
            this.Controls.Add(this.CheckedListBoxAutosToAdd);
            this.Controls.Add(this.richTextBox1);
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
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckedListBox CheckedListBoxAutosToAdd;
        private System.Windows.Forms.Panel PanelFormEditor;
    }
}

