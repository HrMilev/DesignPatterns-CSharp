public class BuilderHouse : IBuilder
{
    House house = new House();

    public void AddRoof()
    {
        this.house.Add("I have ... no roof");
    }

    public void AddDoor()
    {
        this.house.Add("I have ... curtains");
    }

    public void AddWindow()
    {
        this.house.Add("I have windows at least");
    }

    public House GetHouse()
    {
        return house;
    }
}
