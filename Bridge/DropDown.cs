namespace Bridge
{
    public abstract class DropDown
    {
        private readonly IDropDownElement _dropDownElement;

        public DropDown(IDropDownElement dropDownElement)
        {
            _dropDownElement = dropDownElement;
        }

        public virtual string Render()
        {
            return _dropDownElement.Render();
        }

        public abstract string BeingPretty();
    }
}
