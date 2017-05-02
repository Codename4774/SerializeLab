using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerializeLab.Classes;
using System.IO;
using System.ComponentModel;
using SerializeLab.FactoryFormEditor;

namespace SerializeLab.Classes
{
    public class AutoListClass
    {
        private BindingList<dynamic> autoList = new BindingList<dynamic>();
        public BindingList<dynamic> AutoList { set; get; }

        public AutoListClass()
        {
            AutoList = new BindingList<dynamic>();
        }
        
        private char separator = '|';
        public void SerializeList(string fileName)
        {
            StreamWriter file = new StreamWriter(fileName, false, System.Text.Encoding.Default);

            for (int i = 0; i < AutoList.Count; i++)
            {
                AutoList[i].SerializeObject(file, separator);
            }

            file.Flush();
            file.Close();
        }

        public void DeserializeList(string fileName, FactoryAutos factoryAutos)
        {
            const int classIndexPos = 0;

            StreamReader file = new StreamReader(fileName, System.Text.Encoding.Default);

            string fileData = file.ReadToEnd();

            file.Close();

            List<string> fileDataSeparated = fileData.Split(separator).ToList();
            fileDataSeparated.RemoveAt(fileDataSeparated.Count - 1);

            while (fileDataSeparated.Count != 0)
            {
                int classIndex = Convert.ToInt32(fileDataSeparated[classIndexPos]);

                fileDataSeparated.RemoveAt(classIndexPos);
                dynamic addedItem = factoryAutos.FactoryList[classIndex].GetDataObject(classIndex);
                addedItem.DeserializeObject(fileDataSeparated);
                AutoList.Add(addedItem);
            }
        }

    }
}
