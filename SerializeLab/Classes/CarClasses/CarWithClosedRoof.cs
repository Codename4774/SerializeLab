using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace SerializeLab.Classes.CarClasses
{
    class CarWithClosedRoof : Car
    {
        public enum KindOfHatch { Hatch, SlidingHatch, PanoramicSunroof };
        public KindOfHatch KindHatch { set; get; }
        private int saloonVolume;
        public int SaloonVolume
        {
            set
            {
                if (IsCorrectNumb(value))
                {
                    saloonVolume = value;
                }
                else
                {
                    throw new Exception();
                }
            }
            get
            {
                return saloonVolume;
            }
        }
        public CarWithClosedRoof(int classIndex)
            : base(classIndex)
        { }
        public CarWithClosedRoof(int weigth, string color, string mark, int height,
                                 int width, int classIndex, int countPlaces, int bagageCapacity, KindOfHatch kindHatch, int saloonVolume)
            : base(weigth, color, mark, height, width, classIndex, countPlaces, bagageCapacity)
        {
            this.KindHatch = kindHatch;
            this.SaloonVolume = saloonVolume;
        }
    }
}
