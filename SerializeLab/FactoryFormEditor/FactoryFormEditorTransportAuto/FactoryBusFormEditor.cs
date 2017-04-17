using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using SerializeLab.Classes.TransportAutoClasses;
using SerializeLab.Classes;
using System.IO;

namespace SerializeLab.FactoryFormEditor.FactoryFormEditorTransportAuto
{
    class FactoryBusFormEditor : FactoryTransportAutoFormEditor
    {
        public override List<Control> GetListControlsForInput(Size size)
        {
            List<Control> result = base.GetListControlsForInput(size);

            result.Add(GetLabel("KindEngine", size, new Point(5, 360), 15));
            result.Add(GetComboBox("KindEngine", size, new Point(5, 385), 16, Bus.KindOfEngine.DieselEngine.GetType() ));

            return result;
        }
        public override Auto GetDataObject(int classIndex)
        {
            return new Bus(classIndex);
        }

        public override void GetAttribsFromControls(Auto currentAuto, Control.ControlCollection controls)
        {
            base.GetAttribsFromControls(currentAuto, controls);

            const int KindEngineIndex = 7;


            Control[] controlList = GetInputControl(controls);
            try
            {
                Bus currentTransport = (Bus)currentAuto;
                currentTransport.KindEngine = (Bus.KindOfEngine)Enum.Parse(typeof(Bus.KindOfEngine), controlList[KindEngineIndex].Text);
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

            const int KindEngineIndex = 7;

            Control[] controlList = GetInputControl(controls);

            Bus currentTransport = (Bus)currentAuto;
            controlList[KindEngineIndex].Text = Enum.GetName(typeof(Bus.KindOfEngine), currentTransport.KindEngine);
        }

        public override void SerializeObject(StreamWriter file, Auto currentAuto)
        {
            base.SerializeObject(file, currentAuto);

            Bus currentTransport = (Bus)currentAuto;
            file.Write(currentTransport.KindEngine);
            file.Write(Separator);
        }

        public override void DeserializeObject(List<string> data, Auto currentAuto)
        {
            base.DeserializeObject(data, currentAuto);

            const int currentItemList = 0;

            try
            {
                Bus currentTransport = (Bus)currentAuto;
                currentTransport.KindEngine = (Bus.KindOfEngine)Enum.Parse(typeof(Bus.KindOfEngine), data[currentItemList]);
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
