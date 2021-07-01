using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartForOOP
{
    public class Human : Mammal
    {
        public Human(int age) : base(age)
        {
        }

        public override void Move()
        {
            Console.WriteLine("Human move");
        }
        public override bool Beat(Entity entity)
        {
            Console.WriteLine("Human fight");
            return true;
        }
    }
}
