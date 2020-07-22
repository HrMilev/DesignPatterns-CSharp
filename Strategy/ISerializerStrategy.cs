namespace Strategy
{
    //This is the common interface
    public interface ISerializerStrategy
    {
        public string Serialize<T>(T data);
    }
}
