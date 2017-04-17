using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeLab.Classes
{
    public class TransportAuto : Auto
    {
        private int countSittingPlace;
        public int CountSittingPlace
        {
            set
            {
                if (IsCorrectNumb(value))
                {
                    countSittingPlace = value;
                }
                else
                {
                    throw new Exception();
                }
            }
            get
            {
                return countSittingPlace;
            }
        }
        private int countStandingPlace;
        public int CountStandingPlace
        {
            set
            {
                if (IsCorrectNumb(value))
                {
                    countStandingPlace = value;
                }
                else
                {
                    throw new Exception();
                }
            }
            get
            {
                return countStandingPlace;
            }
        }

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
