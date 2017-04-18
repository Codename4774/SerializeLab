using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerializeLab.FactoryFormEditor.FactoryFormEditorCar;
using SerializeLab.FactoryFormEditor.FactoryFormEditorFreightTransport;
using SerializeLab.FactoryFormEditor.FactoryFormEditorTransportAuto;
using SerializeLab.Classes;
using System.IO;
using System.ComponentModel;

namespace SerializeLab.FactoryFormEditor
{
    public class FactoryAutos
    {
        public List<FactoryAuto> factoryList;
        public List<FactoryAuto> FactoryList
        {
            get
            {
                return factoryList;
            }
            private set
            {

            }
        }
        public FactoryAutos()
        {
            factoryList = new List<FactoryAuto>();
            FactoryList.Add(new FactoryCarWithClosedRoof());
            FactoryList.Add(new FactoryCarWithOpenedRoof());
            FactoryList.Add(new FactoryLorry());
            FactoryList.Add(new FactoryTruck());
            FactoryList.Add(new FactoryBus());
            FactoryList.Add(new FactoryTrolleyBus());
        }
    }
}
