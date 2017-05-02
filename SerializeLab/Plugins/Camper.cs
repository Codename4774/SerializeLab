using System;

namespace SerializeLab.Plugins
{
    public class Camper : Special
    {
        private int areaOfLivingSpace;
        public int AreaOfLivingSpace
        {
            get
            {
                return areaOfLivingSpace;
            }
        }

        public override void SerializeObject(StreamWriter file, char separator)
        {
            base.SerializeObject(file, separator);

            file.Write(this.areaOfLivingSpace);
            file.Write(separator);
        }

        public override void DeserializeObject(List<string> data)
        {
            base.DeserializeObject(data);

            const int currentItemList = 0;

            try
            {
                this.areaOfLivingSpace = Convert.ToInt32(data[currentItemList]);
                data.RemoveAt(currentItemList);
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}