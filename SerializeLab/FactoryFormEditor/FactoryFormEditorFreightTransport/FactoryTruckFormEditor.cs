using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using SerializeLab.Classes.FreightTransportClasses;
using SerializeLab.Classes;
using System.IO;

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
            try
            {
                Truck currentTransport = (Truck)currentAuto;
                currentTransport.KindTrailer = (Truck.KindOfTrailer)Enum.Parse(typeof(Truck.KindOfTrailer), controlList[KindTrailerIndex].Text);
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

            const int KindTrailerIndex = 7;

            Control[] controlList = GetInputControl(controls);

            Truck currentTransport = (Truck)currentAuto;
            controlList[KindTrailerIndex].Text = Enum.GetName(typeof(Truck.KindOfTrailer), currentTransport.KindTrailer);
        }

        public override void SerializeObject(StreamWriter file, Auto currentAuto)
        {
            base.SerializeObject(file, currentAuto);

            Truck currentTransport = (Truck)currentAuto;
            file.Write(currentTransport.KindTrailer);
            file.Write(Separator);
        }

        public override void DeserializeObject(List<string> data, Auto currentAuto)
        {

            base.DeserializeObject(data, currentAuto);

            const int currentItemList = 0;

            try
            {
                Truck currentTransport = (Truck)currentAuto;
                currentTransport.KindTrailer = (Truck.KindOfTrailer)Enum.Parse(typeof(Truck.KindOfTrailer), data[currentItemList]);
                data.RemoveAt(currentItemList);
            }
            catch
            {
                MessageBox.Show("Incorrect data. Please, try again.");
                throw new Exception();
            }
        }
    }
}
