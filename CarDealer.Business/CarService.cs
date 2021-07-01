using CarDealer.DataAccess;
using CarDealer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Business
{
    public class CarService
    {
        public List<Car> GetCars()
        {
            CarDAL carDAL = new CarDAL();
            var cars = carDAL.GetCarsFromDB();
            return cars;
        }
    }
}
