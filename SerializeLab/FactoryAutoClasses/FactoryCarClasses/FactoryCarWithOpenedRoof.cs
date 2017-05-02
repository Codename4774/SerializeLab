using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using SerializeLab.Classes.CarClasses;
using SerializeLab.Classes;
using System.IO;

namespace SerializeLab.FactoryFormEditor.FactoryFormEditorCar
{
    class FactoryCarWithOpenedRoof : FactoryCar
    {
        public override List<Control> GetListControlsForInput(Size size)
        {
            List<Control> result = base.GetListControlsForInput(size);

            result.Add(GetLabel("SystemOpeningRoof", size, new Point(5, 360), 15));
            result.Add(GetComboBox("SystemOpeningRoof", size, new Point(5, 385), 16, CarWithOpenRoof.SystemOfOpeningRoof.Automatic.GetType()));

            result.Add(GetLabel("KindRoof", size, new Point(5, 410), 17));
            result.Add(GetComboBox("KindRoof", size, new Point(5, 435), 18, CarWithOpenRoof.KindOfRoof.Hard.GetType()));

            return result;
        }
        public override Auto GetDataObject(int classIndex)
        {
            return new CarWithOpenRoof(classIndex);
        }
        public override void GetAttribsFromControls(Auto currentAuto, Control.ControlCollection controls)
        {
            base.GetAttribsFromControls(currentAuto, controls);

            const int SystemOpeningRoofIndex = 7;
            const int KindRoofIndex = 8;

            Control[] controlList = GetInputControl(controls);
            try
            {
                CarWithOpenRoof currentCar = (CarWithOpenRoof)currentAuto;
                currentCar.SystemOpeningRoof = (CarWithOpenRoof.SystemOfOpeningRoof)Enum.Parse(typeof(CarWithOpenRoof.SystemOfOpeningRoof), controlList[SystemOpeningRoofIndex].Text);
                currentCar.KindRoof = (CarWithOpenRoof.KindOfRoof)Enum.Parse(typeof(CarWithOpenRoof.KindOfRoof), controlList[KindRoofIndex].Text, true);
            }
            catch
            {
                MessageBox.Show("Incorrect data. Please, try again.");
                throw new Exception();
            }        
        }
        public override void AddAttribsToControls(Auto currentAuto, Control.ControlCollection controls)
        {
            base.AddAttribsToControls(currentAuto, controls);

            const int SystemOpeningRoofIndex = 7;
            const int KindRoofIndex = 8;

            Control[] controlList = GetInputControl(controls);

            CarWithOpenRoof currentCar = (CarWithOpenRoof)currentAuto;
            controlList[SystemOpeningRoofIndex].Text = Enum.GetName(typeof(CarWithOpenRoof.SystemOfOpeningRoof), currentCar.SystemOpeningRoof);
            controlList[KindRoofIndex].Text = Enum.GetName(typeof(CarWithOpenRoof.KindOfRoof), currentCar.KindRoof);
        }
        public FactoryCarWithOpenedRoof()
        {
            typeName = "CarWithOpenedRoof";
        }
    }
}
