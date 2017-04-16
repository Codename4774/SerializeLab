using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using SerializeLab.Classes.FreightTransportClasses;

namespace SerializeLab.FactoryFormEditor.FactoryFormEditorFreightTransport
{
    class FactoryTruckFormEditor : FactoryFreightTransportFormEditor
    {
        public override FormEditor GetFormEditor()
        {
            FormEditor result = base.GetFormEditor();

            result.Controls.Add(GetLabel("KindTrailer", new Size(100, 20), new Point(5, 360), 15));
            result.Controls.Add(GetComboBox("KindTrailer", new Size(100, 20), new Point(5, 385), 16, Truck.KindOfTrailer.Detachable.GetType() ));

            return result;
        }
    }
}
