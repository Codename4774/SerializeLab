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
        private BindingList<Auto> autoList = new BindingList<Auto>();
        public BindingList<Auto> AutoList { set; get; }

        public MainForm()
        {
            InitializeComponent();
            ComboBoxInput.SelectedIndex = 0;
            PanelAdding.Controls.Clear();
            PanelAdding.Controls.AddRange(factoryFormEditor.FactoryList[ComboBoxInput.SelectedIndex].GetListControlsForInput(new Size(200, 20)).ToArray());
            PanelAdding.Tag = factoryFormEditor.FactoryList[ComboBoxInput.SelectedIndex].GetDataObject(ComboBoxInput.SelectedIndex); 
            AutoList = new BindingList<Auto>();
            ListBoxAutos.DataSource = AutoList;
            ListBoxAutos.DisplayMember = "Mark";
        }

        private static FactoryFormEditorList factoryFormEditor = new FactoryFormEditorList();

        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ListBoxAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Auto currentAuto = (Auto)ListBoxAutos.SelectedItem;
            PanelEditing.Controls.Clear();
            PanelEditing.Controls.AddRange(factoryFormEditor.FactoryList[currentAuto.ClassIndex].GetListControlsForInput(new Size(200, 20)).ToArray());
            factoryFormEditor.FactoryList[currentAuto.ClassIndex].AddAttribsToControls(currentAuto, PanelEditing.Controls);
            PanelEditing.Tag = currentAuto;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Auto temp = (Auto)PanelAdding.Tag;
            factoryFormEditor.FactoryList[temp.ClassIndex].GetAttribsFromControls(temp, PanelAdding.Controls);
            PanelAdding.Tag = factoryFormEditor.FactoryList[ComboBoxInput.SelectedIndex].GetDataObject(ComboBoxInput.SelectedIndex);
            AutoList.Add(temp);
        }
        private void ComboBoxInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            PanelAdding.Controls.Clear();
            PanelAdding.Controls.AddRange(factoryFormEditor.FactoryList[ComboBoxInput.SelectedIndex].GetListControlsForInput(new Size(200, 20)).ToArray());
            PanelAdding.Tag = factoryFormEditor.FactoryList[ComboBoxInput.SelectedIndex].GetDataObject(ComboBoxInput.SelectedIndex);       
        }

        private void ButtonSubmitEdit_Click(object sender, EventArgs e)
        {
            Auto temp = (Auto)PanelEditing.Tag;
            factoryFormEditor.FactoryList[temp.ClassIndex].GetAttribsFromControls(temp, PanelEditing.Controls);
            AutoList.ResetBindings();
        }
    }
}
