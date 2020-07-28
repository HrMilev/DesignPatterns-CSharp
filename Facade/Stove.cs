using System;

namespace Facade
{
    public class Stove
    {
        private Pan _pan;

        public Stove(Pan pan)
        {
            this._pan = pan;
        }

        internal string Heat()
        {
            return $"Heat up vegetable oil or canola oil in a large {nameof(_pan)}";
        }
    }
}