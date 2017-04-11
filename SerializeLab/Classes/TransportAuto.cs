using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeLab.Classes
{
    abstract class TransportAuto : Auto
    {
        public int CountSittingPlace { get; set; }
        public int CountStandingPlace { get; set; }
        public TransportAuto() : base()
        { }
        public TransportAuto(int weigth, string color, string mark, int height, int width, int mileage, int countSittingPlace, int countStandingPlace)
            : base(weigth, color, mark, height, width, mileage)
        {
            this.CountSittingPlace = countSittingPlace;
            this.CountStandingPlace = countStandingPlace;
        }
    }
}
