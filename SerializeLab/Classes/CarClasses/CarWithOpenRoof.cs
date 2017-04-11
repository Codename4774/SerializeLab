using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
