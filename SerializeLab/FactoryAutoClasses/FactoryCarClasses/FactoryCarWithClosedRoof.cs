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
    class FactoryCarWithClosedRoof : FactoryCar
    {
        public override List<Control> GetListControlsForInput(Size size)
        {
            List<Control> result = base.GetListControlsForInput(size);

            result.Add(GetLabel("KindHatch", size, new Point(5, 360), 15));
            result.Add(GetComboBox("KindHatch", size, new Point(5, 385), 16, CarWithClosedRoof.KindOfHatch.Hatch.GetType()));

            result.Add(GetLabel("SaloonVolume", size, new Point(5, 410), 17));
            result.Add(GetTextBox("SaloonVolume", size, new Point(5, 435), 18, TextBoxNumb_KeyPress));

            return result;
        }
        public override Auto GetDataObject(int classIndex)
        {
            return new CarWithClosedRoof(classIndex);
        }
        public override void GetAttribsFromControls(Auto currentAuto, Control.ControlCollection controls)
        {
            base.GetAttribsFromControls(currentAuto, controls);

            const int KindHatchIndex = 7;
            const int SaloonVolumeIndex = 8;

            Control[] controlList = GetInputControl(controls);
            try
            {
                CarWithClosedRoof currentCar = (CarWithClosedRoof)currentAuto;
                currentCar.KindHatch = (CarWithClosedRoof.KindOfHatch)Enum.Parse(typeof(CarWithClosedRoof.KindOfHatch), controlList[KindHatchIndex].Text);
                currentCar.SaloonVolume = Convert.ToInt32(controlList[SaloonVolumeIndex].Text);
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

            const int KindHatchIndex = 7;
            const int SaloonVolumeIndex = 8;

            Control[] controlList = GetInputControl(controls);

            CarWithClosedRoof currentCar = (CarWithClosedRoof)currentAuto;
            controlList[KindHatchIndex].Text = Enum.GetName(typeof(CarWithClosedRoof.KindOfHatch), currentCar.KindHatch);
            controlList[SaloonVolumeIndex].Text = Convert.ToString(currentCar.SaloonVolume);
        }
    }
}
