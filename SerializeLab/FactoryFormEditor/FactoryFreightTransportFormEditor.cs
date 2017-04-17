using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using SerializeLab.Classes;

namespace SerializeLab.FactoryFormEditor
{
    abstract class FactoryFreightTransportFormEditor : FactoryAutoFormEditor
    {
        public override List<Control> GetListControlsForInput(Size size)
        {
            List<Control> result = base.GetListControlsForInput(size);

            result.Add(GetLabel("MaximumTransporedCargo", size, new Point(5, 260), 11));
            result.Add(GetTextBox("MaximumTransporedCargo", size, new Point(5, 285), 12));

            result.Add(GetLabel("CountAxles", size, new Point(5, 310), 13));
            result.Add(GetTextBox("CountAxles", size, new Point(5, 335), 14));

            return result;
        }
        public override void GetAttribsFromControls(Auto currentAuto, Control.ControlCollection controls)
        {
            base.GetAttribsFromControls(currentAuto, controls);

            const int MaximumTransporedCargoIndex = 5;
            const int CountAxlesIndex = 6;

            Control[] controlList = GetInputControl(controls);

            FreightTransport currentTransport = (FreightTransport)currentAuto;
            currentTransport.MaximumTransporedCargo = Convert.ToInt32(controlList[MaximumTransporedCargoIndex].Text);
            currentTransport.CountAxles = Convert.ToInt32(controlList[CountAxlesIndex].Text);
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
