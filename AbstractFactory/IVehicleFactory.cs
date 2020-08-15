namespace AbstractFactory
{
    public interface IVehicleFactory
    {
        ICar GetCar();
        ITruck GetTruck();
    }
}
