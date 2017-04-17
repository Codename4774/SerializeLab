using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeLab.Classes
{
    public class FreightTransport : Auto
    {
        private int maximumTransporedCargo;
        public int MaximumTransporedCargo
        {
            set
            {
                if (IsCorrectNumb(value))
                {
                    maximumTransporedCargo = value;
                }
                else
                {
                    throw new Exception();
                }
            }
            get
            {
                return maximumTransporedCargo;
            }
        }
        private int countAxles;
        public int CountAxles
        {
            set
            {
                if (IsCorrectNumb(value))
                {
                    countAxles = value;
                }
                else
                {
                    throw new Exception();
                }
            }
            get
            {
                return countAxles;
            }
        }
        public FreightTransport(int classIndex)
            : base(classIndex)
        { }
        public FreightTransport(int weigth, string color, string mark, int height, int width, int classIndex, int maximumTransporedCargo, int countAxles)
            : base(weigth, color, mark, height, width, classIndex)
        {
            this.MaximumTransporedCargo = maximumTransporedCargo;
            this.CountAxles = countAxles;
        }
    }
}
