using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartForOOP
{
    public class Dog : Mammal
    {
        public Dog() : base(1)
        {
        }

        public override void Move()
        {
            Console.WriteLine("Dog move");
        }
        public override bool Beat(Entity entity)
        {
            var beated = base.Beat(entity);
            Console.WriteLine("Dog beat");
            return true;
        }
    }
}
