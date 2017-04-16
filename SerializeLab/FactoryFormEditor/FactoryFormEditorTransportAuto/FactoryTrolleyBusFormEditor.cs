using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using SerializeLab.Classes.TransportAutoClasses;
using SerializeLab.Classes;

namespace SerializeLab.FactoryFormEditor.FactoryFormEditorTransportAuto
{
    class FactoryTrolleyBusFormEditor : FactoryTransportAutoFormEditor
    {
        public override List<Control> GetListControlsForInput(Size size)
        {
            List<Control> result = base.GetListControlsForInput(size);

            result.Add(GetLabel("LengthOfRods", size, new Point(5, 360), 15));
            result.Add(GetTextBox("LengthOfRods", size, new Point(5, 385), 16));

            return result;
        }
        public override Auto GetDataObject()
        {
            return new TrolleyBus();
        }
    }
}
