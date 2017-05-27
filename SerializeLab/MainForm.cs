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
            
            ComboBoxInput.Items.Clear();
            foreach (dynamic currFactory in factoryAutos.FactoryList)
            {
                ComboBoxInput.Items.Add(currFactory.TypeName);
            }
            ComboBoxInput.SelectedIndex = 0;
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
            if (ListBoxAutos.SelectedIndex != -1)
            {
                dynamic currentAuto = list.AutoList[ListBoxAutos.SelectedIndex];

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
            catch(Exception exeption)
            {
                MessageBox.Show(exeption.Message);
                return;
            }
            PanelAdding.Tag = factoryAutos.FactoryList[ComboBoxInput.SelectedIndex].GetDataObject(ComboBoxInput.SelectedIndex);
            ListBoxAutos.Items.Add(temp.Mark);
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
                    ListBoxAutos.Items[ListBoxAutos.SelectedIndex] = temp.Mark;
                }
                catch(Exception exeption)
                {
                    MessageBox.Show(exeption.Message);
                    return;
                }
            }
        }

        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenSerializeFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                try
                {
                    list.DeserializeList(OpenSerializeFileDialog.FileName, factoryAutos);
                }
                catch(Exception exeption)
                {
                    MessageBox.Show(exeption.Message);
                }

                ListBoxAutos.Items.Clear();

                foreach (dynamic auto in list.AutoList)
                {
                    ListBoxAutos.Items.Add(auto.Mark);
                }
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (ListBoxAutos.SelectedItem != null)
            {
                if (MessageBox.Show("Are you sure?", "SerializeLab", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dynamic temp = list.AutoList[ListBoxAutos.SelectedIndex];
                    list.AutoList.Remove(temp);
                    ListBoxAutos.Items.Remove(ListBoxAutos.SelectedItem);
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

        private void ButtonDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "SerializeLab", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                list.AutoList.Clear();
                ListBoxAutos.Items.Clear();
                PanelEditing.Controls.Clear();
                LabelTypeEditedAuto.Text = "";
            }
        }
    }
}
