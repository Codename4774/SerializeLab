using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace SerializeLab.Classes.CarClasses
{
    class CarWithOpenRoof : Car
    {
        public enum SystemOfOpeningRoof { Automatic, Hand };
        public SystemOfOpeningRoof SystemOpeningRoof { set; get; }
        public enum KindOfRoof { Soft, Hard };
        public KindOfRoof KindRoof { set; get; }
        public CarWithOpenRoof(int classIndex)
            : base(classIndex)
        { }
        public CarWithOpenRoof(int weigth, string color, string mark, int height,
                               int width, int classIndex, int countPlaces, int bagageCapacity, SystemOfOpeningRoof systemOpeningRoof,
                               KindOfRoof kindRoof)
            : base(weigth, color, mark, height, width, classIndex, countPlaces, bagageCapacity)
        {
            this.SystemOpeningRoof = systemOpeningRoof;
            this.KindRoof = kindRoof;
        }
        public override void SerializeObject(StreamWriter file, char separator)
        {
            base.SerializeObject(file, separator);

            file.Write(this.SystemOpeningRoof);
            file.Write(separator);
            file.Write(this.KindRoof);
            file.Write(separator);
        }
        public override void DeserializeObject(List<string> data)
        {

            base.DeserializeObject(data);

            const int currentItemList = 0;

            try
            {
                this.SystemOpeningRoof = (CarWithOpenRoof.SystemOfOpeningRoof)Enum.Parse(typeof(CarWithOpenRoof.SystemOfOpeningRoof), data[currentItemList]);
                data.RemoveAt(currentItemList);
                this.KindRoof = (CarWithOpenRoof.KindOfRoof)Enum.Parse(typeof(CarWithOpenRoof.KindOfRoof), data[currentItemList], true);
                data.RemoveAt(currentItemList);
            }
            catch
            {
                throw new Exception("Invalid data");
            }
        }
    }
}
