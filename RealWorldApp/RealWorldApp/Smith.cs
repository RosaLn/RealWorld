using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorldApp
{
    class Smith : Personage
    {
        private new readonly String name = "Smith";
        private int infect;

        public Smith()
        {
            this.infect = 0;
        }
        
        public void setInfect(int max)
        {
            this.infect = Useful.random_Number(1, max+1);
        }

        public int getInfect()
        {
            return this.infect;
        }

        public new String getName()
        {
            return this.name;
        }
    }
}
