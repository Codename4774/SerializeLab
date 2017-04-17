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
            autoList.Add(new CarWithClosedRoof(0));
            autoList.Add(new CarWithOpenRoof(1));
            autoList.Add(new Lorry(2));
            autoList.Add(new Truck(3));
            autoList.Add(new Bus(4));
            autoList.Add(new TrolleyBus(5));
        }
    }
}
