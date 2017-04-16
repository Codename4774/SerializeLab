using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SerializeLab.FactoryFormEditor
{
    abstract class FactoryFreightTransportFormEditor : FactoryAutoFormEditor
    {
        public override List<Control> GetListControlsForInput(Size size)
        {
            List<Control> result = base.GetListControlsForInput(size);

            result.Add(GetLabel("MaximumTransporedCargo", size, new Point(5, 260), 11));
            result.Add(GetTextBox("MaximumTransporedCargo", size, new Point(5, 285), 12));

            result.Add(GetLabel("CountAxles", size, new Point(5, 310), 13));
            result.Add(GetTextBox("CountAxles", size, new Point(5, 335), 14));

            return result;
        }
    }
}
