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
    class FactoryLorry : FactoryFreightTransport
    {
        public override List<Control> GetListControlsForInput(Size size)
        {
            List<Control> result = base.GetListControlsForInput(size);

            result.Add(GetLabel("KindTrunk", size, new Point(5, 360), 15));
            result.Add(GetComboBox("KindTrunk", size, new Point(5, 385), 16, Lorry.KindOfTrunk.Closed.GetType() ));

            result.Add(GetLabel("SystemOfTrunk", size, new Point(5, 410), 17));
            result.Add(GetComboBox("SystemOfTrunk", size, new Point(5, 435), 18, Lorry.FixedOrLiftedTrunk.Fixed.GetType() ));

            return result;
        }
        public override Auto GetDataObject(int classIndex)
        {
            return new Lorry(classIndex);
        }

        public override void GetAttribsFromControls(Auto currentAuto, Control.ControlCollection controls)
        {
            base.GetAttribsFromControls(currentAuto, controls);

            const int KindTrunkIndex = 7;
            const int SystemOfTrunkIndex = 8;

            Control[] controlList = GetInputControl(controls);
            try
            {
                Lorry currentTransport = (Lorry)currentAuto;
                currentTransport.KindTrunk = (Lorry.KindOfTrunk)Enum.Parse(typeof(Lorry.KindOfTrunk), controlList[KindTrunkIndex].Text);
                currentTransport.SystemOfTrunk = (Lorry.FixedOrLiftedTrunk)Enum.Parse(typeof(Lorry.FixedOrLiftedTrunk), controlList[SystemOfTrunkIndex].Text);
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

            const int KindTrunkIndex = 7;
            const int SystemOfTrunkIndex = 8;

            Control[] controlList = GetInputControl(controls);

            Lorry currentTransport = (Lorry)currentAuto;
            controlList[KindTrunkIndex].Text = Enum.GetName(typeof(Lorry.KindOfTrunk), currentTransport.KindTrunk);
            controlList[SystemOfTrunkIndex].Text = Enum.GetName(typeof(Lorry.FixedOrLiftedTrunk), currentTransport.SystemOfTrunk);
        }
    }
}
