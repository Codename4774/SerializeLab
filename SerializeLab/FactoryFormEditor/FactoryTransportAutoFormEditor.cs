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
    abstract class FactoryTransportAutoFormEditor : FactoryAutoFormEditor
    {
        public override List<Control> GetListControlsForInput(Size size)
        {
            List<Control> result = base.GetListControlsForInput(size);

            result.Add(GetLabel("CountSittingPlace", size, new Point(5, 260), 11));
            result.Add(GetTextBox("CountSittingPlace", size, new Point(5, 285), 12));

            result.Add(GetLabel("CountStandingPlace", size, new Point(5, 310), 13));
            result.Add(GetTextBox("CountStandingPlace", size, new Point(5, 335), 14));

            return result;
        }
        public override void GetAttribsFromControls(Auto currentAuto, Control.ControlCollection controls)
        {
            base.GetAttribsFromControls(currentAuto, controls);

            const int CountSittingPlaceIndex = 5;
            const int CountStandingPlaceIndex = 6;

            Control[] controlList = GetInputControl(controls);

            TransportAuto currentTransport = (TransportAuto)currentAuto;
            currentTransport.CountSittingPlace = Convert.ToInt32(controlList[CountSittingPlaceIndex].Text);
            currentTransport.CountStandingPlace = Convert.ToInt32(controlList[CountStandingPlaceIndex].Text);
        }
        public override void AddAttribsToControls(Auto currentAuto, Control.ControlCollection controls)
        {
            base.AddAttribsToControls(currentAuto, controls);

            const int CountSittingPlaceIndex = 5;
            const int CountStandingPlaceIndex = 6;

            Control[] controlList = GetInputControl(controls);

            TransportAuto currentTransport = (TransportAuto)currentAuto;
            controlList[CountSittingPlaceIndex].Text = Convert.ToString(currentTransport.CountSittingPlace);
            controlList[CountStandingPlaceIndex].Text = Convert.ToString(currentTransport.CountStandingPlace);
        }
    }
}
