using System;

namespace Flyweight
{
    public class Brick : IFlyweightBrick
    {
        private readonly IFlyweightBrick _brickImage;
        private readonly int _position;

        public Brick(IFlyweightBrick brickImage, int position)
        {
            _brickImage = brickImage;
            _position = position;
        }

        public byte[] Image => _brickImage.Image;

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
            return _brickImage.Render() + " " + "position " + _position;
        }
    }
}
