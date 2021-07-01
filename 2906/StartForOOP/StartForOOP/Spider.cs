using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartForOOP
{
    public class Spider : Arthropod
    {
        private bool _hasWeb;
        public Spider(int age) : base(age)
        {
        }

        public override bool IsDangerous()
        {
            return base.IsDangerous() || _hasWeb;
        }

        public override void Move()
        {
            Console.WriteLine("Spider move");
        }
    }
}
