using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SerializeLab.Classes.FreightTransportClasses
{
    class Truck : FreightTransport
    {
        public enum KindOfTrailer { Integrated, Detachable };
        public KindOfTrailer KindTrailer { get; set; }
        public Truck(int classIndex)
            : base(classIndex)
        { }
        public Truck(int weigth, string color, string mark, int height, int width, int classIndex, int maximumTransporedCargo, int countAxles,
                     KindOfTrailer kindTrailer)
            : base(weigth, color, mark, height, width, classIndex, maximumTransporedCargo, countAxles)
        {
            this.KindTrailer = kindTrailer;
        }
        public override void SerializeObject(StreamWriter file, char separator)
        {
            base.SerializeObject(file, separator);

            file.Write(this.KindTrailer);
            file.Write(separator);
        }

        public override void DeserializeObject(List<string> data)
        {

            base.DeserializeObject(data);

            const int currentItemList = 0;

            try
            {
                this.KindTrailer = (Truck.KindOfTrailer)Enum.Parse(typeof(Truck.KindOfTrailer), data[currentItemList]);
                data.RemoveAt(currentItemList);
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
