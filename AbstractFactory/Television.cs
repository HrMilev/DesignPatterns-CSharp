partial class Program
{
    public class Television<Brand> : ITelevision where Brand : IBrand, new ()
    {
        private IBrand brand;

        public Television()
        {
            this.brand = new Brand();
        }
        public string Display => brand.Display;
    }
}
