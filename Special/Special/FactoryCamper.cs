using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;


namespace Factory
{
    [NeedToAdd]
    public class FactoryCamper : FactoryAuto
    {
        public override List<Control> GetListControlsForInput(Size size)
        {
            List<Control> result = base.GetListControlsForInput(size);

            result.Add(GetLabel("AreaOfLivingSpace", size, new Point(5, 260), 12));
            result.Add(GetTextBox("AreaOfLivingSpace", size, new Point(5, 285), 13, TextBoxNumb_KeyPress));

            return result;
        }
        public override void GetAttribsFromControls(Auto currentAuto, Control.ControlCollection controls)
        {
            base.GetAttribsFromControls(currentAuto, controls);

            const int AreaOfLivingSpaceIndex = 5;

            Control[] controlList = GetInputControl(controls);
            try
            {
                Camper currentCar = (Camper)currentAuto;
                currentCar.AreaOfLivingSpace = Convert.ToInt32(controlList[AreaOfLivingSpaceIndex].Text);
            }
            catch
            {
                MessageBox.Show("Incorrect data. Please, try again.");
                throw new Exception();
            }
        }
        public override Auto GetDataObject(int classIndex)
        {
            return new Camper(classIndex);
        }
        public override void AddAttribsToControls(Auto currentAuto, Control.ControlCollection controls)
        {
            base.AddAttribsToControls(currentAuto, controls);

            const int AreaOfLivingSpaceIndex = 5;

            Control[] controlList = GetInputControl(controls);
            Camper currentCar = (Camper)currentAuto;
            controlList[AreaOfLivingSpaceIndex].Text = Convert.ToString(currentCar.AreaOfLivingSpace);
        }
        public FactoryCamper()
        {
            typeName = typeof(Camper).Name;
        }
    }
}

