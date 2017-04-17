using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SerializeLab.Classes
{
    public class Car : Auto
    {
        public int CountPlaces { set; get; }
        public int BagageCapacity { set; get; }
        public Car(int classIndex)
            : base(classIndex)
        { }
        public Car(int weigth, string color, string mark, int height, int width, int classIndex, int countPlaces, int bagageCapacity)
            : base(weigth, color, mark, height, width, classIndex)
        {
            this.CountPlaces = countPlaces;
            this.BagageCapacity = bagageCapacity;
        }
    }
}
