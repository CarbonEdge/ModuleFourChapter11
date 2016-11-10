using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFourChapter11
{
    public class AnonTypes
    {
        public static bool FindCar(Car car, string name)
        {
            return car.CarName == name;
        }
    }
}
