namespace Bridge
{
    public class ImageElement : IDropDownElement
    {
        public string Render()
        {
            return "Hello from image";
        }

        public string ShowInfo()
        {
            return "More useful info";
        }
    }
}
