using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class Memento
{
    MemoryStream stream = new MemoryStream();
    BinaryFormatter binaryFormatter = new BinaryFormatter();

    public Memento Save(object o)
    {
        binaryFormatter.Serialize(stream, o);
        return this;
    }

    public object Restore()
    {
        stream.Seek(0, SeekOrigin.Begin);
        object o = binaryFormatter.Deserialize(stream);
        stream.Close();
        return o;
    }
}
