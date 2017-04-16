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
    class FactoryCarWithOpenedRoofFormEditor : FactoryCarFormEditor
    {
        public override List<Control> GetListControlsForInput(Size size)
        {
            List<Control> result = base.GetListControlsForInput(size);

            result.Add(GetLabel("SystemOpeningRoof", size, new Point(5, 360), 15));
            result.Add(GetComboBox("SystemOpeningRoof", size, new Point(5, 385), 16, CarWithOpenRoof.SystemOfOpeningRoof.Automatic.GetType() ));

            result.Add(GetLabel("KindRoof", size, new Point(5, 410), 17));
            result.Add(GetComboBox("KindRoof", size, new Point(5, 435), 18, CarWithOpenRoof.KindOfRoof.Hard.GetType() ));

            return result;
        }
        public override Auto GetDataObject()
        {
            return new CarWithOpenRoof();
        }
    }
}
