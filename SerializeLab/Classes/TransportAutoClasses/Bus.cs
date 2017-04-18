using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SerializeLab.Classes.TransportAutoClasses
{
    class Bus : TransportAuto
    {
        public enum KindOfEngine { GasolineEngine, DieselEngine }
        public KindOfEngine KindEngine { set; get; }
        public Bus(int classIndex)
            : base(classIndex)
        { }
        public Bus(int weigth, string color, string mark, int height, int width, int classIndex, int countSittingPlace, int countStandingPlace,
                   KindOfEngine kindEngine)
            : base(weigth, color, mark, height, width, classIndex, countSittingPlace, countStandingPlace)
        {
            this.KindEngine = kindEngine;
        }
        public override void SerializeObject(StreamWriter file, char separator)
        {
            base.SerializeObject(file, separator);

            file.Write(this.KindEngine);
            file.Write(separator);
        }

        public override void DeserializeObject(List<string> data)
        {
            base.DeserializeObject(data);

            const int currentItemList = 0;

            try
            {
                this.KindEngine = (Bus.KindOfEngine)Enum.Parse(typeof(Bus.KindOfEngine), data[currentItemList]);
                data.RemoveAt(currentItemList);
            }
            catch
            {
                throw new Exception();
            }
        }

    }
}
