using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeLab.Classes
{
    public class TransportAuto : Auto
    {
        public int CountSittingPlace { get; set; }
        public int CountStandingPlace { get; set; }
        public TransportAuto(int classIndex)
            : base(classIndex)
        { }
        public TransportAuto(int weigth, string color, string mark, int height, int width, int classIndex, int countSittingPlace, int countStandingPlace)
            : base(weigth, color, mark, height, width, classIndex)
        {
            this.CountSittingPlace = countSittingPlace;
            this.CountStandingPlace = countStandingPlace;
        }
    }
}
