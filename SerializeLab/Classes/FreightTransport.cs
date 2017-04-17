using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeLab.Classes
{
    public class FreightTransport : Auto
    {
        public int MaximumTransporedCargo { set; get; }

        public int CountAxles { set; get; }
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
