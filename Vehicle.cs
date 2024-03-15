using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public abstract class Vehicle
    {
        private int _speed;
        public int Speed => _speed;
        public abstract void Move();
        public virtual void SpeedUp(int increment)
        {
            _speed += increment;
            Console.WriteLine("Скорость увеличена на " + increment + " км/ч");
        }
        public virtual void SpeedDown(int decrement)
        {
            if (_speed < decrement)
            {
                Console.WriteLine("Скорость не может быть ниже 0 км/ч");
            }
            else
            {
                _speed -= decrement;
                Console.WriteLine("Скорость уменьшена на км/ч " + decrement + " до " + _speed + " км/ч");
            }   
        }
        public override string ToString() => "Транспортное средство";
    }
}
