using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorldApp
{
    class Neo : Personage
    {
        private bool believer;
        private new readonly String name="Neo";

        public Neo()
        {
            this.believer = false;
        }

        public bool isBeliever()
        {
            return this.believer;
        }

        public void setBeliever()
        {
            int num= Useful.random_Number(0, 2);
            if (num == 0)
            {
                this.believer = false;
            }
            else
            {
                this.believer = true;
            }
        }
        public new String getName()
        {
            return this.name;
        }

        public String toString()
        {
            return "name: " + this.name + " age: " + this.age;
        }

    }
}
