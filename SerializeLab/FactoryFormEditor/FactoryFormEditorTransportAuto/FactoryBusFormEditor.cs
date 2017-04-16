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
    class FactoryBusFormEditor : FactoryTransportAutoFormEditor
    {
        public override List<Control> GetListControlsForInput(Size size)
        {
            List<Control> result = base.GetListControlsForInput(size);

            result.Add(GetLabel("KindEngine", size, new Point(5, 360), 15));
            result.Add(GetComboBox("KindEngine", size, new Point(5, 385), 16, Bus.KindOfEngine.DieselEngine.GetType() ));

            return result;
        }
        public override Auto GetDataObject()
        {
            return new Bus();
        }
    }
}
