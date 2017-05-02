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
        AutoListClass list = new AutoListClass();
        public MainForm()
        {
            InitializeComponent();
            ComboBoxInput.SelectedIndex = 0;
            PanelAdding.Controls.Clear();
            PanelAdding.Controls.AddRange(factoryAutos.FactoryList[ComboBoxInput.SelectedIndex].GetListControlsForInput(new Size(200, 20)).ToArray());
            PanelAdding.Tag = factoryAutos.FactoryList[ComboBoxInput.SelectedIndex].GetDataObject(ComboBoxInput.SelectedIndex); 
            
            ListBoxAutos.DataSource = list.AutoList;
            ListBoxAutos.DisplayMember = "Mark";
            ComboBoxInput.Items.Clear();
            foreach (dynamic currFactory in factoryAutos.FactoryList)
            {
                ComboBoxInput.Items.Add(currFactory.TypeName);
            }
        }

        private static AppInitializator appInitializator = new AppInitializator();
        private FactoryAutos factoryAutos = appInitializator.MakeFactoryAutos(appInitializator.GetPlugins());
        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveSerializeFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                list.SerializeList(SaveSerializeFileDialog.FileName);
            }
        }

        private void ListBoxAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            dynamic currentAuto = ListBoxAutos.SelectedItem;
            if (currentAuto != null)
            {
                PanelEditing.Controls.Clear();
                PanelEditing.Controls.AddRange(factoryAutos.FactoryList[currentAuto.ClassIndex].GetListControlsForInput(new Size(200, 20)).ToArray());
                factoryAutos.FactoryList[currentAuto.ClassIndex].AddAttribsToControls(currentAuto, PanelEditing.Controls);
                LabelTypeEditedAuto.Text = ComboBoxInput.Items[currentAuto.ClassIndex].ToString();
                PanelEditing.Tag = currentAuto;
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            dynamic temp = PanelAdding.Tag;
            try
            {
                factoryAutos.FactoryList[temp.ClassIndex].GetAttribsFromControls(temp, PanelAdding.Controls);
            }
            catch
            {
                MessageBox.Show("Incorrect data. Please, try again.");
                return;
            }
            PanelAdding.Tag = factoryAutos.FactoryList[ComboBoxInput.SelectedIndex].GetDataObject(ComboBoxInput.SelectedIndex);
            list.AutoList.Add(temp);
        }
        private void ComboBoxInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            PanelAdding.Controls.Clear();
            PanelAdding.Controls.AddRange(factoryAutos.FactoryList[ComboBoxInput.SelectedIndex].GetListControlsForInput(new Size(200, 20)).ToArray());
            PanelAdding.Tag = factoryAutos.FactoryList[ComboBoxInput.SelectedIndex].GetDataObject(ComboBoxInput.SelectedIndex);       
        }

        private void ButtonSubmitEdit_Click(object sender, EventArgs e)
        {
            if (ListBoxAutos.SelectedItem != null)
            {
                dynamic temp = PanelEditing.Tag;
                try
                {
                    factoryAutos.FactoryList[temp.ClassIndex].GetAttribsFromControls(temp, PanelEditing.Controls);
                }
                catch
                {
                    MessageBox.Show("Incorrect data. Please, try again.");
                    return;
                }
                list.AutoList.ResetBindings();
            }
        }

        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenSerializeFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                list.DeserializeList(OpenSerializeFileDialog.FileName, factoryAutos);
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            
            if (ListBoxAutos.SelectedItem != null)
            {
                if (MessageBox.Show("Are you sure?", "SerializeLab", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dynamic temp = ListBoxAutos.SelectedItem;
                    list.AutoList.Remove(temp);
                    PanelEditing.Controls.Clear();
                    LabelTypeEditedAuto.Text = "";
                }
            }
        }

        private void MenuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
    }
}
