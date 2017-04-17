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
        public TrolleyBus(int classIndex)
            : base(classIndex)
        { }
        public TrolleyBus(int weigth, string color, string mark, int height, int width, int classIndex, int countSittingPlace, int countStandingPlace,
                   int lengthOfRods)
            : base(weigth, color, mark, height, width, classIndex, countSittingPlace, countStandingPlace)
        {
            this.LengthOfRods = lengthOfRods;
        }
    }
}
