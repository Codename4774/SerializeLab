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
    abstract class FactoryFreightTransport : FactoryAuto
    {
        public override List<Control> GetListControlsForInput(Size size)
        {
            List<Control> result = base.GetListControlsForInput(size);

            result.Add(GetLabel("MaximumTransporedCargo", size, new Point(5, 260), 11));
            result.Add(GetTextBox("MaximumTransporedCargo", size, new Point(5, 285), 12, TextBoxNumb_KeyPress));

            result.Add(GetLabel("CountAxles", size, new Point(5, 310), 13));
            result.Add(GetTextBox("CountAxles", size, new Point(5, 335), 14, TextBoxNumb_KeyPress));

            return result;
        }
        public override void GetAttribsFromControls(Auto currentAuto, Control.ControlCollection controls)
        {
            base.GetAttribsFromControls(currentAuto, controls);

            const int MaximumTransporedCargoIndex = 5;
            const int CountAxlesIndex = 6;

            Control[] controlList = GetInputControl(controls);
            try
            {
                FreightTransport currentTransport = (FreightTransport)currentAuto;
                currentTransport.MaximumTransporedCargo = Convert.ToInt32(controlList[MaximumTransporedCargoIndex].Text);
                currentTransport.CountAxles = Convert.ToInt32(controlList[CountAxlesIndex].Text);
            }
            catch
            {
                //MessageBox.Show("Incorrect data. Please, try again.");
                throw new Exception("Invalid data");
            }
        }
        public override void AddAttribsToControls(Auto currentAuto, Control.ControlCollection controls)
        {
            base.AddAttribsToControls(currentAuto, controls);

            const int MaximumTransporedCargoIndex = 5;
            const int CountAxlesIndex = 6;

            Control[] controlList = GetInputControl(controls);

            FreightTransport currentTransport = (FreightTransport)currentAuto;
            controlList[MaximumTransporedCargoIndex].Text = Convert.ToString(currentTransport.MaximumTransporedCargo);
            controlList[CountAxlesIndex].Text = Convert.ToString(currentTransport.CountAxles);
        }
    }
}
