using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using SerializeLab.Classes.TransportAutoClasses;

namespace SerializeLab.FactoryFormEditor.FactoryFormEditorTransportAuto
{
    class FactoryBusFormEditor : FactoryTransportAutoFormEditor
    {
        public override FormEditor GetFormEditor()
        {
            FormEditor result = base.GetFormEditor();

            result.Controls.Add(GetLabel("KindEngine", new Size(100, 20), new Point(5, 360), 15));
            result.Controls.Add(GetComboBox("KindEngine", new Size(100, 20), new Point(5, 385), 16, Bus.KindOfEngine.DieselEngine.GetType() ));

            return result;
        }
    }
}
