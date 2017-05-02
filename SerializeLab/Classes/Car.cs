using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace SerializeLab.Classes
{
    public class Car : Auto
    {
        private int countPlaces;
        public int CountPlaces
        {
            set
            {
                if (IsCorrectNumb(value))
                {
                    countPlaces = value;
                }
                else
                {
                    throw new Exception("Invalid data");
                }
            }
            get
            {
                return countPlaces;
            }
        }
        private int bagageCapacity;
        public int BagageCapacity
        {
            set
            {
                if (IsCorrectNumb(value))
                {
                    bagageCapacity = value;
                }
                else
                {
                    throw new Exception("Invalid data");
                }
            }
            get
            {
                return bagageCapacity;
            }
        }
        public Car(int classIndex)
            : base(classIndex)
        { }
        public Car(int weigth, string color, string mark, int height, int width, int classIndex, int countPlaces, int bagageCapacity)
            : base(weigth, color, mark, height, width, classIndex)
        {
            this.CountPlaces = countPlaces;
            this.BagageCapacity = bagageCapacity;
        }

        public override void SerializeObject(StreamWriter file, char separator)
        {
            base.SerializeObject(file, separator);

            file.Write(this.CountPlaces);
            file.Write(separator);
            file.Write(this.BagageCapacity);
            file.Write(separator);
        }
        public override void DeserializeObject(List<string> data)
        {
            base.DeserializeObject(data);

            const int currentItemList = 0;

            try
            {
                this.CountPlaces = Convert.ToInt32(data[currentItemList]);
                data.RemoveAt(currentItemList);
                this.BagageCapacity = Convert.ToInt32(data[currentItemList]);
                data.RemoveAt(currentItemList);
            }
            catch
            {
                throw new Exception("Invalid data");
            }
        }

    }
}
