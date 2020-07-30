using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Bread : IBakedGood
    {
        private StringBuilder iAm;
        public Bread()
        {
            iAm = new StringBuilder();
            iAm.AppendLine("I am simply hot baked bread");
        }
        public string WhatAmI()
        {
            return iAm.ToString();
        }
    }
}
