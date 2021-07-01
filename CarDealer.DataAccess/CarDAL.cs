using CarDealer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.DataAccess
{
    public class CarDAL
    {
        // seed cars
        List<Car> cars = new List<Car>()
            {
                new Car() {ID = 1, Make = "Opel", Color = System.Drawing.Color.Blue, Description = "Aile arabası", Mileage = 12000, ModelYear = 2019, Price = 320000M, TransmissionType = Transmission.Automatic},
                new Car() {ID = 2, Make = "Nissan", Color = System.Drawing.Color.Red, Description = "Az yakar çok kaçar", Mileage = 87900, ModelYear = 2015, Price = 28000M, TransmissionType = Transmission.Manual},
            };

        public List<Car> GetCarsFromDB()
        {
            // connect to DB, get all cars
            return cars;
        }

    }
}
