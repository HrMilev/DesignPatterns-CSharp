using System;

namespace Facade
{
    public class Stove
    {
        private Pan pan;

        public Stove(Pan pan)
        {
            this.pan = pan;
        }

        internal string Heat()
        {
            return $"Heat up vegetable oil or canola oil in a large {nameof(pan)}";
        }
    }
}