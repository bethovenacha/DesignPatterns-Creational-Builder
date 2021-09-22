using System;
using System.Collections.Generic;

namespace Builder
{
    class Program
    {
        /*
         Builder pattern allows you to separate and reuse a specific process to build something
         */
        static void Main(string[] args)
        {
            NotSoSuperCarBuilder notSoSuperCarBuilder = new NotSoSuperCarBuilder();
            SuperCarBuilder superCarBuilder = new SuperCarBuilder();

            var factory = new CarFactory();
            var builders = new List<CarBuilder>() { 
                            notSoSuperCarBuilder,superCarBuilder
            };

            foreach (var builder in builders) {
                var car = factory.Build(builder);
                Console.WriteLine($"The car requested by " +
                    $"{builder.GetType().Name} " +
                    $"\n----------------------------------------------------" +
                    $"\n Horsepower: { car.HorsePower }" +
                    $"\n Top Speed: {car.TopSpeed  } mph" +
                    $"\n Most Impressive Feature: {car.MostImpressiveFeature } ");
                Console.ReadLine();
            }
        }
    }
}
