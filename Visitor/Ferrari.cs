public class Ferrari : ICar
{
    public int Price { get; set; }

    public void AcceptSalesmen(ISalesmen salesmen)
    {
        salesmen.VisitCar(this);
    }

    public override string ToString()
    {
        return "Ferrari"; 
    }
}
