using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public abstract class Prototype <T>
{
    public T Clone()
    {
        return (T)this.MemberwiseClone();
    }

    public T DeepClone()
    {
        MemoryStream stream = new MemoryStream();
        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Serialize(stream, this);
        stream.Seek(0, 0);
        T copy = (T)formatter.Deserialize(stream);
        stream.Close();
        return copy;
    }
}
