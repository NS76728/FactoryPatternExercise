using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class BigRig : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("The big rig is in drive.");
        }
    }
}
