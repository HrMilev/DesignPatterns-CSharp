partial class Program
{
    public class Refrigerator<Brand> : IRefrigerator where Brand : IBrand, new()
    {
        private IBrand brand;
        public Refrigerator()
        {
            this.brand = new Brand();
        }
        public int Price => brand.Price;
    }
}
