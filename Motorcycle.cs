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
    }
}
