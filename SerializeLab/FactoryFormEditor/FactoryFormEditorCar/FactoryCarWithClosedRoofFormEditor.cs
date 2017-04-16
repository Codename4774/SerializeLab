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
    class FactoryCarWithClosedRoofFormEditor : FactoryCarFormEditor
    {
        public override FormEditor GetFormEditor()
        {
            FormEditor result = base.GetFormEditor();

            result.Controls.Add(GetLabel("KindHatch", new Size(100, 20), new Point(5, 360), 15));
            result.Controls.Add(GetComboBox("KindHatch", new Size(100, 20), new Point(5, 385), 16, CarWithClosedRoof.KindOfHatch.Hatch.GetType()) );

            result.Controls.Add(GetLabel("SaloonVolume", new Size(100, 20), new Point(5, 410), 17));
            result.Controls.Add(GetTextBox("SaloonVolume", new Size(100, 20), new Point(5, 435), 18));

            return result;
        }
    }
}
