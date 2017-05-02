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
using SerializeLab.Classes.CarClasses;
using SerializeLab.Classes.FreightTransportClasses;
using SerializeLab.Classes.TransportAutoClasses;

namespace SerializeLab.FactoryFormEditor
{
    public class FactoryAutos
    {
        private List<dynamic> factoryList;
        public List<dynamic> FactoryList
        {
            get
            {
                return factoryList;
            }
            private set
            {

            }
        }
        public List<string> TypesInfo
        {
            get;
            private set;
        }
        public FactoryAutos()
        {
            factoryList = new List<dynamic>();
            TypesInfo = new List<string>();
            FactoryList.Add(new FactoryCarWithClosedRoof());
            TypesInfo.Add(typeof(CarWithClosedRoof).Name);
            FactoryList.Add(new FactoryCarWithOpenedRoof());
            TypesInfo.Add(typeof(CarWithOpenRoof).Name);
            FactoryList.Add(new FactoryLorry());
            TypesInfo.Add(typeof(Lorry).Name);
            FactoryList.Add(new FactoryTruck());
            TypesInfo.Add(typeof(Truck).Name);
            FactoryList.Add(new FactoryBus());
            TypesInfo.Add(typeof(Bus).Name);
            FactoryList.Add(new FactoryTrolleyBus());
            TypesInfo.Add(typeof(TrolleyBus).Name);
        }
    }
}
