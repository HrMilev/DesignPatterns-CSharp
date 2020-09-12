namespace Flyweight
{
    public interface IFlyweightBrick
    {
        string Render();
        bool AreEqual(IFlyweightBrick flyweightBrick);
        bool ArePicturesEqual(IFlyweightBrick flyweightBrick);
        byte[] Image { get; }
    }
}
