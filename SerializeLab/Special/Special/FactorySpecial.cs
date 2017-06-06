using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

public abstract class FactorySpecialAuto : FactoryAuto
{
    public override List<Control> GetListControlsForInput(Size size)
    {
        List<Control> result = base.GetListControlsForInput(size);

        return result;
    }
    public override void GetAttribsFromControls(Auto currentAuto, Control.ControlCollection controls)
    {
        base.GetAttribsFromControls(currentAuto, controls);

    }
    public override void AddAttribsToControls(Auto currentAuto, Control.ControlCollection controls)
    {
        base.AddAttribsToControls(currentAuto, controls);
    }
}
