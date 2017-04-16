using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using SerializeLab.Classes.FreightTransportClasses;
using SerializeLab.Classes;
namespace SerializeLab.FactoryFormEditor.FactoryFormEditorFreightTransport
{
    class FactoryTruckFormEditor : FactoryFreightTransportFormEditor
    {
        public override List<Control> GetListControlsForInput(Size size)
        {
            List<Control> result = base.GetListControlsForInput(size);

            result.Add(GetLabel("KindTrailer", size, new Point(5, 360), 15));
            result.Add(GetComboBox("KindTrailer", size, new Point(5, 385), 16, Truck.KindOfTrailer.Detachable.GetType() ));

            return result;
        }
        public override Auto GetDataObject()
        {
            return new Truck();
        }
    }
}
