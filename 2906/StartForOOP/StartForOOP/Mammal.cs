using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartForOOP
{
    public abstract class Mammal : Entity
    {
        public virtual int LungsSize { get; set; }

        protected Mammal(int age) : base(age)
        {

        }


        protected override void Breathe()
        {
            //Use lungs
        }

        public virtual bool Beat(Entity entity)
        {
            Console.WriteLine("Mammals dont fight");
            return false;
        }

    }
}
