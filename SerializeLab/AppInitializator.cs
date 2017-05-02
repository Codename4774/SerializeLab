﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using SerializeLab.FactoryFormEditor;

namespace SerializeLab
{
    public class AppInitializator
    {
        private string pluginsDirPath = "Plugins";
        private List<Type> GetNewFactories(List<Type> plugins)
        {
            List<Type> result = new List<Type>();

            foreach (Type currPlugin in plugins)
            {
                if ((!currPlugin.IsAbstract) && (currPlugin.Name.IndexOf("Factory") >= 0))
                {
                    result.Add(currPlugin);
                }
            }
            return result;
        }
        public List<Type> GetPlugins()
        {
            List<Type> pluginsList = new List<Type>();

            string[] pluginsFileList = Directory.GetFiles(pluginsDirPath);

            for (int i = 0; i < pluginsFileList.Length; i++)
            {
                if ((String.Compare(Path.GetExtension(pluginsFileList[i]), ".dll") == 0))
                {
                    Assembly asm = Assembly.LoadFrom(pluginsFileList[i]);

                    List<Type> typesInAsm = asm.GetTypes().ToList();
                    typesInAsm = GetNewFactories(typesInAsm);
                    for (int j = 0; j < typesInAsm.Count; j++)
                    {
                        pluginsList.Add(typesInAsm[j]);
                    }
                }
            }
            return pluginsList;
        }

        private List<Type> autotypeNameList = new List<Type>();
        public List<Type> AutotypeNameList
        {
            get
            {
                return (autotypeNameList);
            }
            private set
            { }
        }

        public FactoryAutos MakeFactoryAutos(List<Type> plugins)
        {
            FactoryAutos result = new FactoryAutos();

            foreach (Type currPlugin in plugins)
            {
                object temp = Activator.CreateInstance(currPlugin);
                result.FactoryList.Add(temp);
            }

            return result;
        }
        
    }
}