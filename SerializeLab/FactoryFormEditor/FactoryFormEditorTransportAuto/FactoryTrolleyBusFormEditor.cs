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
    class FactoryTrolleyBusFormEditor : FactoryTransportAutoFormEditor
    {
        public override List<Control> GetListControlsForInput(Size size)
        {
            List<Control> result = base.GetListControlsForInput(size);

            result.Add(GetLabel("LengthOfRods", size, new Point(5, 360), 15));
            result.Add(GetTextBox("LengthOfRods", size, new Point(5, 385), 16, TextBoxNumb_KeyPress));

            return result;
        }
        public override Auto GetDataObject(int classIndex)
        {
            return new TrolleyBus(classIndex);
        }

        public override void GetAttribsFromControls(Auto currentAuto, Control.ControlCollection controls)
        {
            base.GetAttribsFromControls(currentAuto, controls);

            const int LengthOfRodsIndex = 7;


            Control[] controlList = GetInputControl(controls);
            try
            {
                TrolleyBus currentTransport = (TrolleyBus)currentAuto;
                currentTransport.LengthOfRods = Convert.ToInt32(controlList[LengthOfRodsIndex].Text);
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

            const int LengthOfRodsIndex = 7;

            Control[] controlList = GetInputControl(controls);

            TrolleyBus currentTransport = (TrolleyBus)currentAuto;
            controlList[LengthOfRodsIndex].Text = Convert.ToString(currentTransport.LengthOfRods);
        }

        public override void SerializeObject(StreamWriter file, Auto currentAuto)
        {
            base.SerializeObject(file, currentAuto);

            TrolleyBus currentTransport = (TrolleyBus)currentAuto;
            file.Write(currentTransport.LengthOfRods);
            file.Write(Separator);
        }

        public override void DeserializeObject(List<string> data, Auto currentAuto)
        {
            base.DeserializeObject(data, currentAuto);

            const int currentItemList = 0;

            try
            {
                TrolleyBus currentTransport = (TrolleyBus)currentAuto;
                currentTransport.LengthOfRods = Convert.ToInt32(data[currentItemList]);
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
