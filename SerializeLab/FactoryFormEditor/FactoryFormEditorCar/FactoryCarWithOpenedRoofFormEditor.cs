using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using SerializeLab.Classes.CarClasses;

namespace SerializeLab.FactoryFormEditor.FactoryFormEditorCar
{
    class FactoryCarWithOpenedRoofFormEditor : FactoryCarFormEditor
    {
        public override FormEditor GetFormEditor()
        {
            FormEditor result = base.GetFormEditor();

            result.Controls.Add(GetLabel("SystemOpeningRoof", new Size(100, 20), new Point(5, 360), 15));
            result.Controls.Add(GetComboBox("SystemOpeningRoof", new Size(100, 20), new Point(5, 385), 16, CarWithOpenRoof.SystemOfOpeningRoof.Automatic.GetType() ));

            result.Controls.Add(GetLabel("KindRoof", new Size(100, 20), new Point(5, 410), 17));
            result.Controls.Add(GetComboBox("KindRoof", new Size(100, 20), new Point(5, 435), 18, CarWithOpenRoof.KindOfRoof.Hard.GetType() ));

            return result;
        }

    }
}
