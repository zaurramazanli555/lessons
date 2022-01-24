using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass_enum
{
    public partial class Car : BaseClass<Car>
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int SeatCount { get; set; } //oturacaq sayi
        public string SeatMaterial { get; set; } //Oturacaq Deri/Parca
        public int Door { get; set; }
        public int Engine { get; set; }
        public string FuelType { get; set; }

        public override Car Get(int id)
        {
            return new Car();
        }

        public override Car[] GetAll()
        {
            return new Car[10];
        }

        public override int Add(Car item)
        {
            return 1;
        }

        public override Car Update(Car item)
        {
            return new Car();
        }

        public override bool Delete(int id)
        {
            return true;
        }
    }
}
