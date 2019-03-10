public class BuilderLuxHouse : IBuilder
{
    House house = new House();

    public void AddRoof()
    {
        this.house.Add("I have roof with tiles");
    }

    public void AddDoor()
    {
        this.house.Add("I have front door");
    }

    public void AddWindow()
    {
        this.house.Add("I have windows on the roof");
    }

    public House GetHouse()
    {
        return house;
    }
}
