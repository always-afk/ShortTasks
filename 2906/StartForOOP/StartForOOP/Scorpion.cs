using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartForOOP
{
    public class Scorpion : Arthropod
    {
        public bool HasTale { get; }
        public Scorpion() : this(0) { }
        public Scorpion(int age) : base(age)
        {
            HasTale = true;
        }

        public override bool IsDangerous()
        {
            return base.IsDangerous() || HasTale;
        }
        public override void Move()
        {
            Console.WriteLine("Scorpion move");
        }
    }
}
