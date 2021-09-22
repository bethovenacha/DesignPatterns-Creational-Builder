using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
   public class CarFactory
    {
        public Car Build(CarBuilder builder) {
            builder.SetHorsePower();
            builder.SetTopSpeed();
            builder.SetMostImpressiveFeature();
            return builder.GetCar();
        }
    }
}
