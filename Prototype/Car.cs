using System;

[Serializable]
public class Car : Prototype<Car>
{
    public string Type { get; set; }
    public string Color { get; set; }
    public Engine Engine { get; set; }

    public override string ToString()
    {
        return this.GetType() + "\n" + "--Type: " + Type + "\n" + "--Color: " + Color + "\n" + "--Engine: " + Engine.Type + "\n";
    }
}
