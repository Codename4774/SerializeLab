using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerializeLab.Classes.CarClasses;
using SerializeLab.Classes.FreightTransportClasses;
using SerializeLab.Classes.TransportAutoClasses;

namespace SerializeLab.Classes
{
    public class AutoTypeList
    {

        public List<Auto> autoList;
        public List<Auto> AutoList
        {
                get
                {
                    return autoList;
                }
                private set
                {

                }
            }
        public AutoTypeList()
        {
            autoList = new List<Auto>();
            autoList.Add(new CarWithClosedRoof());
            autoList.Add(new CarWithOpenRoof());
            autoList.Add(new Lorry());
            autoList.Add(new Truck());
            autoList.Add(new Bus());
            autoList.Add(new TrolleyBus());
        }
    }
}
