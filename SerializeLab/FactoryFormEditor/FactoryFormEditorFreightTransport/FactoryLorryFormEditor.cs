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
    class FactoryLorryFormEditor : FactoryFreightTransportFormEditor
    {
        public override List<Control> GetListControlsForInput(Size size)
        {
            List<Control> result = base.GetListControlsForInput(size);

            result.Add(GetLabel("KindTrunk", size, new Point(5, 360), 15));
            result.Add(GetComboBox("KindTrunk", size, new Point(5, 385), 16, Lorry.KindOfTrunk.Closed.GetType() ));

            result.Add(GetLabel("SystemOfTrunk", size, new Point(5, 410), 17));
            result.Add(GetComboBox("SystemOfTrunk", size, new Point(5, 435), 18, Lorry.FixedOrLiftedTrunk.Fixed.GetType() ));

            return result;
        }
        public override Auto GetDataObject()
        {
            return new Lorry();
        }
    }
}
