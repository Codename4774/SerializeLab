using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using SerializeLab.Classes.FreightTransportClasses;
using SerializeLab.Classes;
namespace SerializeLab.FactoryFormEditor.FactoryFormEditorFreightTransport
{
    class FactoryTruckFormEditor : FactoryFreightTransportFormEditor
    {
        public override List<Control> GetListControlsForInput(Size size)
        {
            List<Control> result = base.GetListControlsForInput(size);

            result.Add(GetLabel("KindTrailer", size, new Point(5, 360), 15));
            result.Add(GetComboBox("KindTrailer", size, new Point(5, 385), 16, Truck.KindOfTrailer.Detachable.GetType() ));

            return result;
        }
        public override Auto GetDataObject(int classIndex)
        {
            return new Truck(classIndex);
        }
        public override void GetAttribsFromControls(Auto currentAuto, Control.ControlCollection controls)
        {
            base.GetAttribsFromControls(currentAuto, controls);

            const int KindTrailerIndex = 7;

            Control[] controlList = GetInputControl(controls);

            Truck currentTransport = (Truck)currentAuto;
            currentTransport.KindTrailer = (Truck.KindOfTrailer)Enum.Parse(typeof(Truck.KindOfTrailer), controlList[KindTrailerIndex].Text);
        }
        public override void AddAttribsToControls(Auto currentAuto, Control.ControlCollection controls)
        {
            base.AddAttribsToControls(currentAuto, controls);

            const int KindTrailerIndex = 7;

            Control[] controlList = GetInputControl(controls);

            Truck currentTransport = (Truck)currentAuto;
            controlList[KindTrailerIndex].Text = Enum.GetName(typeof(Truck.KindOfTrailer), currentTransport.KindTrailer);
        }
    }
}
