namespace Flyweight
{
    public class BrickFactory
    {
        //this could be a e.g. dictionary with different shared immutable objects
        private static IFlyweightBrick Img = new BrickImage("Nice image of a brick");
        public IFlyweightBrick GetBrick(int position)
        {
            return new Brick(Img, position);
        }
    }
}
