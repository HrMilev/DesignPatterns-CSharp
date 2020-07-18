public class Divide : IOperation
{
    double internalNumber;
    public Divide(double internalNumber)
    {
        this.internalNumber = internalNumber;
    }
    public double By(double number)
    {
        return internalNumber / number;
    }
}
