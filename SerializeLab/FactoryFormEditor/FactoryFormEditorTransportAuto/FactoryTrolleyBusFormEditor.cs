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
    class FactoryTrolleyBusFormEditor : FactoryTransportAutoFormEditor
    {
        public override FormEditor GetFormEditor()
        {
            FormEditor result = base.GetFormEditor();

            result.Controls.Add(GetLabel("LengthOfRods", new Size(100, 20), new Point(5, 360), 15));
            result.Controls.Add(GetTextBox("LengthOfRods", new Size(100, 20), new Point(5, 385), 16));

            return result;
        }
    }
}
