partial class Program
{
    public interface IFactory<Brand> where Brand : IBrand
    {
        ITelevision CreateTV();
        IRefrigerator CreateRefrigerator();
    }
}
