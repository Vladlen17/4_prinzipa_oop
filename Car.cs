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
        public override void SpeedUp(int increment)
        {
            _speed += increment;
            Console.WriteLine("Скорость автомобиля увеличена на " + increment + " км/ч");
        }
        public override void SpeedDown(int decrement)
        {
            if (_speed < decrement)
            {
                Console.WriteLine("Скорость автомобиля не может быть ниже 0 км/ч");
            }
            else
            {
                _speed -= decrement;
                Console.WriteLine("Скорость автомобиля уменьшена на км/ч " + decrement + " до " + _speed + " км/ч");
            }
        }
    }
}
