namespace Flyweight
{
    public class BrickImage : IFlyweightBrick
    {
        public BrickImage(string img)
        {
            Image = System.Text.Encoding.UTF8.GetBytes(img);
        }

        public byte[] Image { get; }

        public bool AreEqual(IFlyweightBrick flyweightBrick)
        {
            return flyweightBrick == this;
        }

        public bool ArePicturesEqual(IFlyweightBrick flyweightBrick)
        {
            return flyweightBrick.Image == Image;
        }

        public string Render()
        {
            return System.Text.Encoding.UTF8.GetString(Image, 0, Image.Length);
        }
    }
}
