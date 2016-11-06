using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFourChapter11
{
    public class Car
    {
        public int CarID { get; set; }
        public string CarName { get; set; }
        public int CarQuantity { get; set;  }
    }
    public class CarDealer:overload
    {
        private List<Car> ListCars;
        public CarDealer()
        {
            ListCars = new List<Car>();
            ListCars.Add(new Car() { CarID =1, CarName="Toyota", CarQuantity =10});
            ListCars.Add(new Car() { CarID = 2, CarName = "BMW", CarQuantity = 1 });
            ListCars.Add(new Car() { CarID = 3, CarName = "Ford", CarQuantity = 13 });
            ListCars.Add(new Car() { CarID = 4, CarName = "Merc", CarQuantity = 6 });
        }
        public string this[int carid]
        {
            get {
                return ListCars.FirstOrDefault(p => p.CarID == carid).CarName;
            }
            set {
                ListCars.FirstOrDefault(p => p.CarID == carid).CarName= value;
            }
        }

        public string this[string name, int qty]
        {
            get
            {
                return ListCars.FirstOrDefault(p => p.CarName== name).CarName;
            }
            set
            {
                ListCars.FirstOrDefault(p => p.CarQuantity !=0).CarQuantity = qty;
            }
        }
    }
}
