using System;
using System.Text;

namespace Facade
{
    public class CookingFacade : ICookingFacade
    {
        private Stove stove;
        private Pan pan;
        private Chicken chicken;

        public CookingFacade(Stove stove, Pan pan, Chicken chicken)
        {
            this.stove = stove;
            this.pan = pan;
            this.chicken = chicken;
        }

        public string GetChickenOnStove()
        {
            var sb = new StringBuilder();
            sb.AppendLine(chicken.Seasoning());
            sb.AppendLine(stove.Heat());
            sb.AppendLine(pan.AddChicken());
            sb.AppendLine("Again is overcooked ... this facade is wrong ...");
            return sb.ToString();
        }
    }
}