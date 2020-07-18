public class DummyCalculator
{
    double internalNumber;
    IOperation operation = new Multiply(0);
    public DummyCalculator(double internalNumber)
    {
        this.internalNumber = internalNumber;

    }

    public DummyCalculator ChooseOperation(IOperation operation)
    {
        this.operation = operation;
        return this;
    }

    public void By(double number)
    {
        internalNumber = operation.By(number);
    }

    public double InternalNumber => internalNumber;
}
