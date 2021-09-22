using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public abstract class CarBuilder
    {
        protected readonly Car _car = new Car();
        public abstract void SetHorsePower();
        public abstract void SetTopSpeed();
        public abstract void SetMostImpressiveFeature();

        public virtual Car GetCar() {
            return _car;
        }
    }
}
