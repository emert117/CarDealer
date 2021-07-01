using CarDealer.Business;
using System;

namespace CarDealer.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Car Dealer Software!");
            // get all cars and print
            CarService carService = new CarService();
            var cars = carService.GetCars();
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Make} {car.Price}");
            }
            Console.ReadLine();
        }
    }
}
