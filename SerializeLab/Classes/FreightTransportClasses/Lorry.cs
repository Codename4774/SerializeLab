using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeLab.Classes.FreightTransportClasses
{
    class Lorry : FreightTransport
    {
        public enum KindOfTrunk { Opened, Closed };
        public KindOfTrunk KindTrunk { set; get; }
        public enum FixedOrLiftedTrunk { Fixed, Lifted };
        public FixedOrLiftedTrunk SystemOfTrunk { set; get; }
        public Lorry(int classIndex)
            : base(classIndex)
        { }
        public Lorry(int weigth, string color, string mark, int height, int width, int classIndex, int maximumTransporedCargo, int countAxles,
                     KindOfTrunk kindTrunk, FixedOrLiftedTrunk systemOfTrunk)
            : base(weigth, color, mark, height, width, classIndex, maximumTransporedCargo, countAxles)
        {
            this.KindTrunk = kindTrunk;
            this.SystemOfTrunk = systemOfTrunk;
        }
    }
}
