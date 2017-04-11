using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeLab.Classes
{
    abstract class FreightTransport : Auto
    {
        public int MaximumTransporedCargo { set; get; }

        public int CountAxles { set; get; }
        public FreightTransport() : base()
        { }
        public FreightTransport(int weigth, string color, string mark, int height, int width, int mileage, int maximumTransporedCargo, int countAxles)
            : base(weigth, color, mark, height, width, mileage)
        {
            this.MaximumTransporedCargo = maximumTransporedCargo;
            this.CountAxles = countAxles;
        }
    }
}
