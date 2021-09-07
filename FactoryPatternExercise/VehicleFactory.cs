using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public static class VehicleFactory 
    {
        static VehicleFactory()
        {

        }

        public static IVehicle GetVehicle(string tireNum)
        {
            int tires = Convert.ToInt32(tireNum);
            if (tires > 4)
                return new BigRig();
            else
                return new Car();
            
        }






    }
}
