using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class NotSoSuperCarBuilder : CarBuilder
    {
        public override void SetHorsePower()
        {
             _car.HorsePower = 70;
        }

        public override void SetMostImpressiveFeature()
        {
            _car.MostImpressiveFeature = "Has air conditioning.";
        }

        public override void SetTopSpeed()
        {
            _car.TopSpeed = 120;
        }
    }
}
