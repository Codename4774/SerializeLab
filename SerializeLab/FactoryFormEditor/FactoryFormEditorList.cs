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
        public void SerializeList(string fileName, BindingList<Auto> list, FactoryFormEditorList factoryFormEditor)
        {
            StreamWriter file = new StreamWriter(fileName, false, System.Text.Encoding.Default);

            for (int i = 0; i < list.Count; i++)
            {
                factoryFormEditor.FactoryList[list[i].ClassIndex].SerializeObject(file, list[i]);
            }

            file.Flush();
            file.Close();
        }

        public void DeserializeList(string fileName, BindingList<Auto> list, FactoryFormEditorList factoryFormEditor)
        {
            const int ClassIndexPos = 0;

            StreamReader file = new StreamReader(fileName, System.Text.Encoding.Default);

            string fileData = file.ReadToEnd();

            file.Close();

            List<string> fileDataSeparated = fileData.Split(factoryFormEditor.FactoryList[0].Separator).ToList();
            fileDataSeparated.RemoveAt(fileDataSeparated.Count - 1);

            while (fileDataSeparated.Count != 0)
            {
                int classIndex = Convert.ToInt32(fileDataSeparated[ClassIndexPos]);

                fileDataSeparated.RemoveAt(ClassIndexPos);
                Auto addedItem = factoryFormEditor.FactoryList[classIndex].GetDataObject(classIndex);
                factoryFormEditor.FactoryList[classIndex].DeserializeObject(fileDataSeparated, addedItem);
                list.Add(addedItem);
            }
        }
    }
}
