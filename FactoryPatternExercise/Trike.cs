using System;
namespace FactoryPatternExercise
{
    public class Trike : IVehicle
    {
        public Trike()
        {
        }
        public void Drive()
        {
            Console.WriteLine("Building a new trike...not sure how it's going to go");
        }
    }
}
