partial class Program
{
    public class Factory<Brand> : IFactory<Brand> where Brand : IBrand, new()
    {
        
        public IRefrigerator CreateRefrigerator()
        {
            return new Refrigerator<Brand>();
        }

        public ITelevision CreateTV()
        {
            return new Television<Brand>();
        }
    }
}
