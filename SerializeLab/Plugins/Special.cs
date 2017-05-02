using System;

namespace SerializeLab.Classes
{
    public class Special : Auto
    {
        public override void SerializeObject(StreamWriter file, char separator)
        {
            base.SerializeObject(file, separator);
        }

        public override void DeserializeObject(List<string> data)
        {
            base.DeserializeObject(data);
        }
    }
}