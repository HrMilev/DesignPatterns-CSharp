public class DoTheJob : IDoTheJob
{
    private Worker worker = new Worker();
    public void Work()
    {
        worker.GetTheShovel();
    }
}
