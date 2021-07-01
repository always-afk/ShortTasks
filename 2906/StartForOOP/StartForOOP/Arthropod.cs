using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartForOOP
{
    public abstract class Arthropod : Entity
    {
        public virtual int EyeCount { get; set; }
        private bool _hasPoison;

        protected Arthropod(int age) : base(age)
        {
            _hasPoison = false;
        }

        public virtual bool IsDangerous()
        {
            return _hasPoison;
        }

        protected override void Breathe()
        {
            //Dont use lungs
        }        
    }
}
