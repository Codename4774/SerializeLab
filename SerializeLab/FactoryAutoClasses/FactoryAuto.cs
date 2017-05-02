using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using SerializeLab.Classes;
using System.IO;

namespace SerializeLab.FactoryFormEditor
{
    public abstract class FactoryAuto
    {

        public void TextBoxText_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int backSpaceCode = 8;

            if (!Char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != backSpaceCode) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        public void TextBoxNumb_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int backSpaceCode = 8;

            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != backSpaceCode))
            {
                e.Handled = true;
            }
        }
        protected string typeName;
        public string TypeName
        {
            get
            {
                return typeName;
            }
            private set
            {
 
            }
        }
        public TextBox GetTextBox(string name, Size size, Point location, int tabIndex, KeyPressEventHandler eventKeyPress)
        {
            TextBox result = new TextBox();

            result.Location = location;
            result.Name = name;
            result.Size = size;
            result.TabIndex = tabIndex;
            result.KeyPress += eventKeyPress;


            return result;
        }

        public Label GetLabel(string name, Size size, Point location, int tabIndex)
        {
            Label result = new Label();

            result.Location = location;
            result.Name = name;
            result.Text = name;
            result.Size = size;
            result.TabIndex = tabIndex;

            return result;
        }

        public ComboBox GetComboBox(string name, Size size, Point location, int tabIndex, Type enumType)
        {
            ComboBox result = new ComboBox();

            result.Location = location;
            result.Name = name;
            result.Size = size;
            result.TabIndex = tabIndex;
            result.Items.AddRange(Enum.GetNames(enumType));
            result.SelectedIndex = 0;
            result.DropDownStyle = ComboBoxStyle.DropDownList;

            return result;
        }

        public virtual List<Control> GetListControlsForInput(Size size)
        {
            List<Control> result = new List<Control>();

            result.Add(GetLabel("Weigth", size, new Point(5, 10), 1));
            result.Add(GetTextBox("Weigth", size, new Point(5, 35), 2, TextBoxNumb_KeyPress));

            result.Add(GetLabel("Color", size, new Point(5, 60), 3));
            result.Add(GetTextBox("Color", size, new Point(5, 85), 4, TextBoxText_KeyPress));

            result.Add(GetLabel("Mark", size, new Point(5, 110), 5));
            result.Add(GetTextBox("Mark", size, new Point(5, 135), 6, TextBoxText_KeyPress));

            result.Add(GetLabel("Width", size, new Point(5, 160), 7));
            result.Add(GetTextBox("Width", size, new Point(5, 185), 8, TextBoxNumb_KeyPress));

            result.Add(GetLabel("Height", size, new Point(5, 210), 9));
            result.Add(GetTextBox("Height", size, new Point(5, 235), 10, TextBoxNumb_KeyPress));

            return result;
        }

        public abstract Auto GetDataObject(int classIndex);

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

        public virtual void GetAttribsFromControls(Auto currentAuto, Control.ControlCollection controls) 
        {
            const int WeightIndex = 0;
            const int ColorIndex = 1;
            const int MarkIndex = 2;
            const int HeightIndex = 3;
            const int WidthIndex = 4;

            Control[] controlList = GetInputControl(controls);

            try
            {
                currentAuto.Weigth = Convert.ToInt32(controlList[WeightIndex].Text);
                currentAuto.Color = controlList[ColorIndex].Text;
                currentAuto.Mark = controlList[MarkIndex].Text;
                currentAuto.Height = Convert.ToInt32(controlList[HeightIndex].Text);
                currentAuto.Width = Convert.ToInt32(controlList[WidthIndex].Text);
            }
            catch
            {
                MessageBox.Show("Incorrect data. Please, try again.");
                throw new Exception();
            }
        }
        public virtual void AddAttribsToControls(Auto currentAuto, Control.ControlCollection controls)
        {
            const int WeightIndex = 0;
            const int ColorIndex = 1;
            const int MarkIndex = 2;
            const int HeightIndex = 3;
            const int WidthIndex = 4;

            Control[] controlList = GetInputControl(controls);

            controlList[WeightIndex].Text = Convert.ToString(currentAuto.Weigth);
            controlList[ColorIndex].Text = currentAuto.Color;
            controlList[MarkIndex].Text = currentAuto.Mark;
            controlList[HeightIndex].Text = Convert.ToString(currentAuto.Height);
            controlList[WidthIndex].Text = Convert.ToString(currentAuto.Width);
        }
    }
}
