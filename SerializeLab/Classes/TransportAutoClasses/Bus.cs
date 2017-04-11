using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeLab.Classes.TransportAutoClasses
{
    class Bus : TransportAuto
    {
        public enum KindOfEngine { GasolineEngine, DieselEngine }
        public KindOfEngine KindEngine { set; get; }
        public Bus()
            : base()
        { }
        public Bus(int weigth, string color, string mark, int height, int width, int mileage, int countSittingPlace, int countStandingPlace,
                   KindOfEngine kindEngine)
            : base(weigth, color, mark, height, width, mileage, countSittingPlace, countStandingPlace)
        {
            this.KindEngine = kindEngine;
        }

    }
}
