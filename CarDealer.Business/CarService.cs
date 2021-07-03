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
            // recheck user permissions
            // CheckUserRole("Admin,PremiumUser")
            // Cross Cutting Concerns

            // apply restrictions

            // request from cache

            // get from DB
            CarDAL carDAL = new CarDAL();
            var cars = carDAL.GetCarsFromDB();
            // apply rules that DB can't run

            // finally return result
            return cars;
        }
    }
}
