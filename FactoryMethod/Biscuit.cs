using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Biscuit : IBakedGood
    {
        private StringBuilder iAm;
        public Biscuit(string ingredient)
        {
            iAm = new StringBuilder();
            iAm.AppendLine(ingredient);
            iAm.AppendLine("And i am a delicious biscuit");
        }

        public string WhatAmI()
        {
            return iAm.ToString();
        }
    }
}
