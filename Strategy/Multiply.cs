public class Multiply : IOperation
{
    double internalNumber;
    public Multiply(double internalNumber)
    {
        this.internalNumber = internalNumber;
    }
    public double By(double number)
    {
        return internalNumber * number;
    }
}
