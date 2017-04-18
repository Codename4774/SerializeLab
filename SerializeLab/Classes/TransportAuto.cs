using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SerializeLab.Classes
{
    public class TransportAuto : Auto
    {
        private int countSittingPlace;
        public int CountSittingPlace
        {
            set
            {
                if (IsCorrectNumb(value))
                {
                    countSittingPlace = value;
                }
                else
                {
                    throw new Exception();
                }
            }
            get
            {
                return countSittingPlace;
            }
        }
        private int countStandingPlace;
        public int CountStandingPlace
        {
            set
            {
                if (IsCorrectNumb(value))
                {
                    countStandingPlace = value;
                }
                else
                {
                    throw new Exception();
                }
            }
            get
            {
                return countStandingPlace;
            }
        }

        public TransportAuto(int classIndex)
            : base(classIndex)
        { }
        public TransportAuto(int weigth, string color, string mark, int height, int width, int classIndex, int countSittingPlace, int countStandingPlace)
            : base(weigth, color, mark, height, width, classIndex)
        {
            this.CountSittingPlace = countSittingPlace;
            this.CountStandingPlace = countStandingPlace;
        }
        public override void SerializeObject(StreamWriter file, char separator)
        {
            base.SerializeObject(file, separator);

            file.Write(this.CountSittingPlace);
            file.Write(separator);
            file.Write(this.CountStandingPlace);
            file.Write(separator);
        }

        public override void DeserializeObject(List<string> data)
        {
            base.DeserializeObject(data);

            const int currentItemList = 0;

            try
            {
                this.CountSittingPlace = Convert.ToInt32(data[currentItemList]);
                data.RemoveAt(currentItemList);
                this.CountStandingPlace = Convert.ToInt32(data[currentItemList]);
                data.RemoveAt(currentItemList);
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
