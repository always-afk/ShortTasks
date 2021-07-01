using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartForOOP
{
    public abstract class Entity
    {
        public int Weight { get; set; }
        public int Age { get; }

        protected Entity(int age)
        {
            Age = age;
        }

        public abstract void Move();
        protected virtual void Breathe() { }        
    }
}
