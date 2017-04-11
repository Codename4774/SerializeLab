using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeLab.Classes.FreightTransportClasses
{
    class Truck : FreightTransport
    {
        public enum KindOfTrailer { Integrated, Detachable };
        public KindOfTrailer KindTrailer { get; set; }
        public Truck()
            : base()
        { }
        public Truck(int weigth, string color, string mark, int height, int width, int mileage, int maximumTransporedCargo, int countAxles,
                     KindOfTrailer kindTrailer)
            : base(weigth, color, mark, height, width, mileage, maximumTransporedCargo, countAxles)
        {
            this.KindTrailer = kindTrailer;
        }
    }
}
