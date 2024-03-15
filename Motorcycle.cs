using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Motorcycle : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Мотоцикл мчится по трассе");
        }
        public override string ToString()
        {
            return "Мотоцикл";
        }
        public override void SpeedUp(int increment)
        {
            _speed += increment;
            Console.WriteLine("Скорость мотоцикла увеличена на " + increment + " км/ч");
        }
        public override void SpeedDown(int decrement)
        {
            if (_speed < decrement)
            {
                Console.WriteLine("Скорость мотоцикла не может быть ниже 0 км/ч");
            }
            else
            {
                _speed -= decrement;
                Console.WriteLine("Скорость мотоцикла уменьшена на км/ч " + decrement + " до " + _speed + " км/ч");
            }
        }
    }
}
