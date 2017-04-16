using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using SerializeLab.Classes.CarClasses;
using SerializeLab.Classes;

namespace SerializeLab.FactoryFormEditor.FactoryFormEditorCar
{
    class FactoryCarWithClosedRoofFormEditor : FactoryCarFormEditor
    {
        public override List<Control> GetListControlsForInput(Size size)
        {
            List<Control> result = base.GetListControlsForInput(size);

            result.Add(GetLabel("KindHatch", size, new Point(5, 360), 15));
            result.Add(GetComboBox("KindHatch", size, new Point(5, 385), 16, CarWithClosedRoof.KindOfHatch.Hatch.GetType()));

            result.Add(GetLabel("SaloonVolume", size, new Point(5, 410), 17));
            result.Add(GetTextBox("SaloonVolume", size, new Point(5, 435), 18));

            return result;
        }
        public override Auto GetDataObject()
        {
            return new CarWithClosedRoof();
        }
    }

}
