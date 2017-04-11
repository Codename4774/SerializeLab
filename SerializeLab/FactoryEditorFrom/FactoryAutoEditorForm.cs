using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SerializeLab.FactoryEditorFrom
{
    abstract class FactoryAutoEditorForm
    {
        public TextBox GetTextBox(string name, Size size, Point location, int tabIndex)
        {
            TextBox result = new TextBox();

            result.Location = location;
            result.Name = name;
            result.Text = name;
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
        public virtual FormEditor GetFormEditor()
        {
            FormEditor result = new FormEditor();

            result.Controls.Add(GetLabel("Weigth", new Size(100, 20), new Point(5, 10), 1));
            result.Controls.Add(GetTextBox("Weigth", new Size(100, 20), new Point(5, 35), 2));
            
            result.Controls.Add(GetLabel("Color", new Size(100, 20), new Point(5, 60), 3));
            result.Controls.Add(GetTextBox("Color", new Size(100, 20), new Point(5, 85), 4));

            result.Controls.Add(GetLabel("Mark", new Size(100, 20), new Point(5, 110), 5));
            result.Controls.Add(GetTextBox("Mark", new Size(100, 20), new Point(5, 135), 6));

            result.Controls.Add(GetLabel("Width", new Size(100, 20), new Point(5, 160), 7));
            result.Controls.Add(GetTextBox("Width", new Size(100, 20), new Point(5, 185), 8));

            result.Controls.Add(GetLabel("Height", new Size(100, 20), new Point(5, 210), 9));
            result.Controls.Add(GetTextBox("Height", new Size(100, 20), new Point(5, 235), 10));

            return result;
        }
    }
}
