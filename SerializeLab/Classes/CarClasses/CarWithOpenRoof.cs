using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SerializeLab.Classes.CarClasses
{
    class CarWithOpenRoof : Car
    {
        public enum SystemOfOpeningRoof { Automatic, Hand };
        public SystemOfOpeningRoof SystemOpeningRoof { set; get; }
        public enum KindOfRoof { Soft, Hard };
        public KindOfRoof KindRoof { set; get; }
        public CarWithOpenRoof()
            : base()
        { }
        public CarWithOpenRoof(int weigth, string color, string mark, int height,
                               int width, int mileage, int countPlaces, int bagageCapacity, SystemOfOpeningRoof systemOpeningRoof,
                               KindOfRoof kindRoof)
            : base(weigth, color, mark, height, width, mileage, countPlaces, bagageCapacity)
        {
            this.SystemOpeningRoof = systemOpeningRoof;
            this.KindRoof = kindRoof;
        }

        public override void GetAttributesFromControls(Control[] controlList)
        {
            const int SystemOpeningRoofIndex = 7;
            const int KindRoofIndex = 8;

            base.GetAttributesFromControls(controlList);

            SystemOpeningRoof = (SystemOfOpeningRoof)Enum.Parse(typeof(SystemOfOpeningRoof), controlList[SystemOpeningRoofIndex].Text);
            KindRoof = (KindOfRoof)Enum.Parse(typeof(KindOfRoof), controlList[KindRoofIndex].Text, true);
        }
    }
}
