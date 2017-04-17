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
    abstract class FactoryFreightTransportFormEditor : FactoryAutoFormEditor
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
                MessageBox.Show("Incorrect data. Please, try again.");
                throw new Exception();
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

        public override void SerializeObject(StreamWriter file, Auto currentAuto)
        {
            base.SerializeObject(file, currentAuto);

            FreightTransport currentTransport = (FreightTransport)currentAuto;
            file.Write(currentTransport.MaximumTransporedCargo);
            file.Write(Separator);
            file.Write(currentTransport.CountAxles);
            file.Write(Separator);
        }

        public override void DeserializeObject(List<string> data, Auto currentAuto)
        {
            base.DeserializeObject(data, currentAuto);

            const int currentItemList = 0;

            try
            {
                FreightTransport currentTransport = (FreightTransport)currentAuto;
                currentTransport.MaximumTransporedCargo = Convert.ToInt32(data[currentItemList]);
                data.RemoveAt(currentItemList);
                currentTransport.CountAxles = Convert.ToInt32(data[currentItemList]);
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
