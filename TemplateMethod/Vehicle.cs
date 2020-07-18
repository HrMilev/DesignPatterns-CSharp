public abstract class Vehicle
{
    protected abstract void GetIn();
    protected abstract void StartTheEngine();
    protected abstract void GoGoGo();

    public void RunTemplate()
    {
        this.GetIn();
        this.StartTheEngine();
        this.GoGoGo();
    }
}
