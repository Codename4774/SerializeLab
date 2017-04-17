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
        private int countPlaces;
        public int CountPlaces
        {
            set
            {
                if (IsCorrectNumb(value))
                {
                    countPlaces = value;
                }
                else
                {
                    throw new Exception();
                }
            }
            get
            {
                return countPlaces;
            }
        }
        private int bagageCapacity;
        public int BagageCapacity
        {
            set
            {
                if (IsCorrectNumb(value))
                {
                    bagageCapacity = value;
                }
                else
                {
                    throw new Exception();
                }
            }
            get
            {
                return bagageCapacity;
            }
        }
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
