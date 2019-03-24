public class Salesman : ISalesmen
{
    private int addPrice;
    private int countOfCars;
    public Salesman(int addPrice)
    {
        this.addPrice = addPrice;
    }
    public void VisitCar(ICar car)
    {
        car.Price = car.Price + addPrice;
        countOfCars++;
    }

    public string CountOfCars()
    {
        return "The actual cars are " + countOfCars;
    }
}
