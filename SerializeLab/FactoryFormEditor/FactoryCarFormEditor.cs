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
        public override List<Control> GetListControlsForInput(Size size)
        {
            List<Control> result = base.GetListControlsForInput(size);

            result.Add(GetLabel("CountPlaces", size, new Point(5, 260), 12));
            result.Add(GetTextBox("CountPlaces", size, new Point(5, 285), 13));

            result.Add(GetLabel("BagageCapacity", size, new Point(5, 310), 14));
            result.Add(GetTextBox("BagageCapacity", size, new Point(5, 335), 15));

            return result;
        }
    }
}
