using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Entities
{
    public class Car
    {
        public int ID { get; set; }
        public string Make { get; set; }
        public Color Color { get; set; }
        public int ModelYear { get; set; }
        public int Mileage { get; set; }
        public Transmission TransmissionType { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
