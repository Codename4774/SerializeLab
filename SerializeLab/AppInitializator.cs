using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using SerializeLab.FactoryFormEditor;
using AttributesAndCommonClasses;

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
                
                foreach(dynamic attrib in currPlugin.CustomAttributes)
                if (attrib.AttributeType.Name == "NeedToAdd")
                {
                    result.Add(currPlugin);
                }
            }
            return result;
        }
        private List<Type> GetNewFunctionalPlugins(List<Type> plugins)
        {
            List<Type> result = new List<Type>();

            foreach (Type currPlugin in plugins)
            {

                foreach (CustomAttributeData attrib in currPlugin.CustomAttributes)
                    if (attrib.AttributeType == typeof(AttributesAndCommonClasses.Attributes.AddAttribute))
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
                    Assembly library = Assembly.LoadFrom(pluginsFileList[i]);
                    List<Type> typesInLibrary = library.GetTypes().ToList();

                    typesInLibrary = GetNewFactories(typesInLibrary);
                    for (int j = 0; j < typesInLibrary.Count; j++)
                    {
                        pluginsList.Add(typesInLibrary[j]);
                    }
                }
            }
            return pluginsList;
        }
        public Type GetFunctionalPlugin(string fileName)
        {
            List<Type> pluginsList = new List<Type>();


            Assembly library = Assembly.LoadFrom(fileName);
            List<Type> typesInLibrary = library.GetTypes().ToList();

            typesInLibrary = GetNewFunctionalPlugins(typesInLibrary);

            for (int j = 0; j < typesInLibrary.Count; j++)
            {
                pluginsList.Add(typesInLibrary[j]);
            }

            return pluginsList[0];
        }

        public object CreateFunctionalClass(Type plugin, MainForm form)
        {
            object result = null;
            ConstructorInfo[] constructors = plugin.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                foreach (CustomAttributeData attrib in constructor.CustomAttributes)
                {
                    if (attrib.AttributeType == typeof(AttributesAndCommonClasses.Attributes.MainConstructorAttribute))
                    {
                        ParameterInfo[] parameterInfo = constructor.GetParameters();
                        List<object> args = new List<object>();
                        foreach (ParameterInfo parameter in parameterInfo)
                        {
                            foreach (CustomAttributeData paramsAttrib in parameter.CustomAttributes)
                            {
                                if (paramsAttrib.AttributeType == typeof(AttributesAndCommonClasses.Attributes.AddMenuItemAttribute))
                                {
                                    args.Add(form.MainMenuStrip);
                                }

                                if (paramsAttrib.AttributeType == typeof(AttributesAndCommonClasses.Attributes.AddDecipherDataAttribute))
                                {
                                }

                            }
                        }
                        result = Activator.CreateInstance(plugin, args.ToArray());
                    }
                }
            }
            MethodInfo[] methodsInfo = plugin.GetMethods();
            foreach (MethodInfo methodInfo in methodsInfo)
            {
                foreach (CustomAttributeData attrib in methodInfo.CustomAttributes)
                {
                    if (attrib.AttributeType == typeof(AttributesAndCommonClasses.Attributes.AddCipherDataAttribute))
                    {
                        form.cipherEvent = (CommonClasses.DataProcessingDelegate)methodInfo.CreateDelegate(typeof(CommonClasses.DataProcessingDelegate), result);
                    }
                    if (attrib.AttributeType == typeof(AttributesAndCommonClasses.Attributes.AddDecipherDataAttribute))
                    {
                        form.decipherEvent = (CommonClasses.DataProcessingDelegate)methodInfo.CreateDelegate(typeof(CommonClasses.DataProcessingDelegate), result);
                    }
                }
            }
            return result;
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
                dynamic temp = Activator.CreateInstance(currPlugin);
                result.FactoryList.Add(temp);
                result.TypesInfo.Add(temp.TypeName);
            }

            return result;
        }
    }
}
