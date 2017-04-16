using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using SerializeLab.Classes;

namespace SerializeLab.FactoryFormEditor
{
    public abstract class FactoryAutoFormEditor
    {
        public TextBox GetTextBox(string name, Size size, Point location, int tabIndex)
        {
            TextBox result = new TextBox();

            result.Location = location;
            result.Name = name;
            result.Size = size;
            result.TabIndex = tabIndex;

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
            result.Add(GetTextBox("Weigth", size, new Point(5, 35), 2));

            result.Add(GetLabel("Color", size, new Point(5, 60), 3));
            result.Add(GetTextBox("Color", size, new Point(5, 85), 4));

            result.Add(GetLabel("Mark", size, new Point(5, 110), 5));
            result.Add(GetTextBox("Mark", size, new Point(5, 135), 6));

            result.Add(GetLabel("Width", size, new Point(5, 160), 7));
            result.Add(GetTextBox("Width", size, new Point(5, 185), 8));

            result.Add(GetLabel("Height", size, new Point(5, 210), 9));
            result.Add(GetTextBox("Height", size, new Point(5, 235), 10));

            return result;
        }

        public abstract Auto GetDataObject();
    }
}
