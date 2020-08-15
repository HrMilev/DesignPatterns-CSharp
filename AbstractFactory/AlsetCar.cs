using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class AlsetCar : ICar
    {
        public string Type()
        {
            return "I am complex to build object of type electric car";
        }
    }
}
