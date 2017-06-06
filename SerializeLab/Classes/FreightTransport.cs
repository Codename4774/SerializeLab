using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SerializeLab.Classes
{
    public class FreightTransport : Auto
    {
        private int maximumTransporedCargo;
        public int MaximumTransporedCargo
        {
            set
            {
                if (IsCorrectNumb(value))
                {
                    maximumTransporedCargo = value;
                }
                else
                {
                    throw new Exception("Invalid data");
                }
            }
            get
            {
                return maximumTransporedCargo;
            }
        }
        private int countAxles;
        public int CountAxles
        {
            set
            {
                if (IsCorrectNumb(value))
                {
                    countAxles = value;
                }
                else
                {
                    throw new Exception("Invalid data");
                }
            }
            get
            {
                return countAxles;
            }
        }
        public FreightTransport(int classIndex)
            : base(classIndex)
        { }
        public FreightTransport(int weigth, string color, string mark, int height, int width, int classIndex, int maximumTransporedCargo, int countAxles)
            : base(weigth, color, mark, height, width, classIndex)
        {
            this.MaximumTransporedCargo = maximumTransporedCargo;
            this.CountAxles = countAxles;
        }
        public override void SerializeObject(StreamWriter file, char separator)
        {
            base.SerializeObject(file, separator);

            file.Write(this.MaximumTransporedCargo);
            file.Write(separator);
            file.Write(this.CountAxles);
            file.Write(separator);
        }

        public override void DeserializeObject(List<string> data)
        {
            base.DeserializeObject(data);

            const int currentItemList = 0;

            try
            {
                this.MaximumTransporedCargo = Convert.ToInt32(data[currentItemList]);
                data.RemoveAt(currentItemList);
                this.CountAxles = Convert.ToInt32(data[currentItemList]);
                data.RemoveAt(currentItemList);
            }
            catch
            {
                throw new Exception("Invalid data");
            }
        }
    }
}
