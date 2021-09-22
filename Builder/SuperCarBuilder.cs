using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class SuperCarBuilder : CarBuilder
    {
        public override void SetHorsePower()
        {
            _car.HorsePower = 2000;
        }

        public override void SetMostImpressiveFeature()
        {
            _car.MostImpressiveFeature = "Can Fly";
        }

        public override void SetTopSpeed()
        {
            _car.TopSpeed = 600;
        }
    }
}
