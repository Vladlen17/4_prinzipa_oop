using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Автомобиль движется по дороге");
        }
        public override string ToString()
        {
            return "Автомобиль";
        }
    }
}
