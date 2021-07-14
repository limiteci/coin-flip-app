using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coin_flip
{
    class Class1
    {
        public bool isHeads { get; set; }

        // constructor for new coin
        public Class1(bool h)
        {
            this.isHeads = h;
        }

        public void flipcoin(Random r)
        {
            // randomly choose a new heads or tails value for the boolean/coin
            if (r.Next(10) > 5)
            {
                this.isHeads = true;
            }
            else
            {
                this.isHeads = false;
            }
        }
    }
}
