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
    class FactoryLorryFormEditor : FactoryFreightTransportFormEditor
    {
        public override FormEditor GetFormEditor()
        {
            FormEditor result = base.GetFormEditor();

            result.Controls.Add(GetLabel("KindTrunk", new Size(100, 20), new Point(5, 360), 15));
            result.Controls.Add(GetComboBox("KindTrunk", new Size(100, 20), new Point(5, 385), 16, Lorry.KindOfTrunk.Closed.GetType() ));

            result.Controls.Add(GetLabel("SystemOfTrunk", new Size(100, 20), new Point(5, 410), 17));
            result.Controls.Add(GetComboBox("SystemOfTrunk", new Size(100, 20), new Point(5, 435), 18, Lorry.FixedOrLiftedTrunk.Fixed.GetType() ));

            return result;
        }
    }
}
