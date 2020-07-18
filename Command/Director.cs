public class Director
{
    private readonly IDoTheJob jobber;

    public Director(IDoTheJob jobber)
    {
        this.jobber = jobber;
    }

    public void GoToWork()
    {
        jobber.Work();
    }
}
