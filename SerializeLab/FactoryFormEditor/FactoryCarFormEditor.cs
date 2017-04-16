using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SerializeLab.FactoryFormEditor
{
    abstract class FactoryCarFormEditor : FactoryAutoFormEditor
    {
        public override FormEditor GetFormEditor()
        {
            FormEditor result = base.GetFormEditor();

            result.Controls.Add(GetLabel("CountPlaces", new Size(100, 20), new Point(5, 260), 11));
            result.Controls.Add(GetTextBox("CountPlaces", new Size(100, 20), new Point(5, 285), 12));

            result.Controls.Add(GetLabel("BagageCapacity", new Size(100, 20), new Point(5, 310), 13));
            result.Controls.Add(GetTextBox("BagageCapacity", new Size(100, 20), new Point(5, 335), 14));

            return result;
        }
    }
}
