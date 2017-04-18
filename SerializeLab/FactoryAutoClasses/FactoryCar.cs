using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using SerializeLab.Classes;
using System.IO;

namespace SerializeLab.FactoryFormEditor
{
    abstract class FactoryCar : FactoryAuto
    {
        public override List<Control> GetListControlsForInput(Size size)
        {
            List<Control> result = base.GetListControlsForInput(size);

            result.Add(GetLabel("CountPlaces", size, new Point(5, 260), 12));
            result.Add(GetTextBox("CountPlaces", size, new Point(5, 285), 13, TextBoxNumb_KeyPress));

            result.Add(GetLabel("BagageCapacity", size, new Point(5, 310), 14));
            result.Add(GetTextBox("BagageCapacity", size, new Point(5, 335), 15, TextBoxNumb_KeyPress));

            return result;
        }
        public override void GetAttribsFromControls(Auto currentAuto, Control.ControlCollection controls)
        {
            base.GetAttribsFromControls(currentAuto, controls);

            const int CountPlacesIndex = 5;
            const int BagageCapacityIndex = 6;

            Control[] controlList = GetInputControl(controls);
            try
            {
                Car currentCar = (Car)currentAuto;
                currentCar.CountPlaces = Convert.ToInt32(controlList[CountPlacesIndex].Text);
                currentCar.BagageCapacity = Convert.ToInt32(controlList[BagageCapacityIndex].Text);
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

            const int CountPlacesIndex = 5;
            const int BagageCapacityIndex = 6;

            Control[] controlList = GetInputControl(controls);
            Car currentCar = (Car)currentAuto;
            controlList[CountPlacesIndex].Text = Convert.ToString(currentCar.CountPlaces);
            controlList[BagageCapacityIndex].Text = Convert.ToString(currentCar.BagageCapacity);
        }
    }
}
