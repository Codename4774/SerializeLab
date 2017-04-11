using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeLab.Classes.TransportAutoClasses
{
    class TrolleyBus : TransportAuto
    {
        public int LengthOfRods { set; get; }
        public TrolleyBus()
            : base()
        { }
        public TrolleyBus(int weigth, string color, string mark, int height, int width, int mileage, int countSittingPlace, int countStandingPlace,
                   int lengthOfRods)
            : base(weigth, color, mark, height, width, mileage, countSittingPlace, countStandingPlace)
        {
            this.LengthOfRods = lengthOfRods;
        }
    }
}
