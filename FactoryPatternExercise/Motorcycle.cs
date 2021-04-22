﻿using System;
namespace FactoryPatternExercise
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }

        public void Drive()
        {
            Console.WriteLine("Building a new motorcycle..vroom vroom");
        }
    }
}
