using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerializeLab.FactoryFormEditor.FactoryFormEditorCar;
using SerializeLab.FactoryFormEditor.FactoryFormEditorFreightTransport;
using SerializeLab.FactoryFormEditor.FactoryFormEditorTransportAuto;

namespace SerializeLab.FactoryFormEditor
{
    public class FactoryFormEditorList
    {
        public List<FactoryAutoFormEditor> factoryList;
        public List<FactoryAutoFormEditor> FactoryList
        {
            get
            {
                return factoryList;
            }
            private set
            {

            }
        }
        public FactoryFormEditorList()
        {
            factoryList = new List<FactoryAutoFormEditor>();
            FactoryList.Add(new FactoryCarWithClosedRoofFormEditor());
            FactoryList.Add(new FactoryCarWithOpenedRoofFormEditor());
            FactoryList.Add(new FactoryLorryFormEditor());
            FactoryList.Add(new FactoryTruckFormEditor());
            FactoryList.Add(new FactoryBusFormEditor());
            FactoryList.Add(new FactoryTrolleyBusFormEditor());
        }
    }
}
