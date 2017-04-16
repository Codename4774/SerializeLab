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
        private List<Auto> autoList = new List<Auto>();
        public List<Auto> AutoList
        { set; get; }

        public Control[] GetInputControl(Control.ControlCollection controlList)
        {
            List<Control> result = new List<Control>();
            Label temp = new Label();
            Type labelType = temp.GetType();

            for (int i = 0; i < controlList.Count; i++)
            {
                if (controlList[i].GetType() != labelType)
                {
                    result.Add(controlList[i]);
                }
            }
            return result.ToArray();
        }

        public MainForm()
        {
            InitializeComponent();
            ComboBoxInput.SelectedIndex = 0;
            PanelFormEditor.Controls.Clear();
            PanelFormEditor.Controls.AddRange(factoryFormEditor.FactoryList[ComboBoxInput.SelectedIndex].GetListControlsForInput(new Size(200, 20)).ToArray());
            PanelFormEditor.Tag = factoryFormEditor.FactoryList[ComboBoxInput.SelectedIndex].GetDataObject(); 
            AutoList = new List<Auto>();
            ListBoxAutos.DataSource = AutoList;
            ListBoxAutos.DisplayMember = "Mark";
        }

        private static FactoryFormEditorList factoryFormEditor = new FactoryFormEditorList();

        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ListBoxAutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Auto temp = (Auto)PanelFormEditor.Tag;
            temp.GetAttributesFromControls(GetInputControl(PanelFormEditor.Controls));
            AutoList.Add(temp);
            ListBoxAutos.DataSource = AutoList;
            ListBoxAutos.DisplayMember = "Mark";
            ListBoxAutos.SelectedValueChanged += new EventHandler(ListBoxAutos_SelectedIndexChanged);

        }
        private void ComboBoxInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            PanelFormEditor.Controls.Clear();
            PanelFormEditor.Controls.AddRange(factoryFormEditor.FactoryList[ComboBoxInput.SelectedIndex].GetListControlsForInput(new Size(200, 20)).ToArray());
            PanelFormEditor.Tag = factoryFormEditor.FactoryList[ComboBoxInput.SelectedIndex].GetDataObject();       
        }
    }
}
