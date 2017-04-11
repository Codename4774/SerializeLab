using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeLab.Classes
{
    abstract class Car : Auto
    {
        public int CountPlaces { set; get; }
        public int BagageCapacity { set; get; }
        public Car()
            : base()
        { }
        public Car(int weigth, string color, string mark, int height, int width, int mileage, int countPlaces, int bagageCapacity)
            : base(weigth, color, mark, height, width, mileage)
        {
            this.CountPlaces = countPlaces;
            this.BagageCapacity = bagageCapacity;
        }
    }
}
