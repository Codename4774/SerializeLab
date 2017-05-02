using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SerializeLab.Classes.FreightTransportClasses
{
    class Lorry : FreightTransport
    {
        public enum KindOfTrunk { Opened, Closed };
        public KindOfTrunk KindTrunk { set; get; }
        public enum FixedOrLiftedTrunk { Fixed, Lifted };
        public FixedOrLiftedTrunk SystemOfTrunk { set; get; }
        public Lorry(int classIndex)
            : base(classIndex)
        { }
        public Lorry(int weigth, string color, string mark, int height, int width, int classIndex, int maximumTransporedCargo, int countAxles,
                     KindOfTrunk kindTrunk, FixedOrLiftedTrunk systemOfTrunk)
            : base(weigth, color, mark, height, width, classIndex, maximumTransporedCargo, countAxles)
        {
            this.KindTrunk = kindTrunk;
            this.SystemOfTrunk = systemOfTrunk;
        }
        public override void SerializeObject(StreamWriter file, char separator)
        {
            base.SerializeObject(file, separator);

            file.Write(this.KindTrunk);
            file.Write(separator);
            file.Write(this.SystemOfTrunk);
            file.Write(separator);
        }

        public override void DeserializeObject(List<string> data)
        {

            base.DeserializeObject(data);

            const int currentItemList = 0;

            try
            {
                this.KindTrunk = (Lorry.KindOfTrunk)Enum.Parse(typeof(Lorry.KindOfTrunk), data[currentItemList]);
                data.RemoveAt(currentItemList);
                this.SystemOfTrunk = (Lorry.FixedOrLiftedTrunk)Enum.Parse(typeof(Lorry.FixedOrLiftedTrunk), data[currentItemList]);
                data.RemoveAt(currentItemList);
            }
            catch
            {
                throw new Exception("Invalid data");
            }
        }
    }
}
