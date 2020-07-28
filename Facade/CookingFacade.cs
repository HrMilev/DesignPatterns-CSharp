using System;
using System.Text;

namespace Facade
{
    public class CookingFacade : ICookingFacade
    {
        private Stove _stove;
        private Pan _pan;
        private Chicken _chicken;

        public CookingFacade(Stove stove, Pan pan, Chicken chicken)
        {
            this._stove = stove;
            this._pan = pan;
            this._chicken = chicken;
        }

        public string GetChickenOnStove()
        {
            var sb = new StringBuilder();
            sb.AppendLine(_chicken.Seasoning());
            sb.AppendLine(_stove.Heat());
            sb.AppendLine(_pan.AddChicken());
            sb.AppendLine("Again is overcooked ... this facade is wrong ...");
            return sb.ToString();
        }
    }
}