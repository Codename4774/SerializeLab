using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerializeLab.Classes;

using SerializeLab.FactoryFormEditor;

namespace SerializeLab
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private static FactoryFormEditorList factoryFormEditor = new FactoryFormEditorList();

        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ListBoxAutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckedListBoxAutosToAdd_Click(object sender, EventArgs e)
        {

        }

        private void CheckedListBoxAutosToAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CheckedListBoxAutosToAdd.CheckedItems.Count > 1)
            {
                for (int i = 0; i < CheckedListBoxAutosToAdd.Items.Count; i++)
                {
                    CheckedListBoxAutosToAdd.SetItemChecked(i, false);
                }
                CheckedListBoxAutosToAdd.SetItemCheckState(CheckedListBoxAutosToAdd.SelectedIndex, CheckState.Checked);
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            FormEditor formForEdit = factoryFormEditor.FactoryList[CheckedListBoxAutosToAdd.SelectedIndex].GetFormEditor();
            formForEdit.Show();
            
        }
    }
}
