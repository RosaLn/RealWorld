using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorldApp
{
    class Personage : InterfaceGenerate
    {
        internal class Location
        {
            protected static readonly String[] names = { "Nueva York", "Boston", "Baltimore",
                "Atlanta", "Detroit", "Dallas", "Denver" };
            protected int latitude;
            protected int longitude;
            protected String city;

            public Location()
            {
                this.latitude = Useful.random_Number(0, 100);
                this.longitude = Useful.random_Number(0, 100);
                this.city = names[Useful.random_Number(0, 6)];
            }

            public int getLatitude()
            {
                return this.latitude;
            }

            public int getLongitude()
            {
                return this.longitude;
            }
            
            public String getCity()
            {
                return this.city;
            }
        }

        protected static readonly String[] names = { "Michelle ", "Alexander",
            "James   ", "Caroline ", "Claire   ", "Jessica  ", "Erik     ", "Mike     " };
        protected String name;
        protected Location location;
        protected int age;
        private int percentageDie;


        public Personage()
        {
            this.name = names[Useful.random_Number(0,7)];
            this.location = new Location();
            this.age = Useful.random_Number(18, 100);
            this.percentageDie = Useful.random_Number(0, 100);
        }

        public String getName()
        {
            return this.name;
        }
        public int getAge()
        {
            return this.age;
        }

        public void setPercentage(int n)
        {
            this.percentageDie=n;
        }
        public int getPercentageDie()
        {
            return this.percentageDie;
        }

        public void incrementPercentage()
        {
            if (!(getPercentageDie() >= 70))
            {
                this.percentageDie += 10;
            }
        }

        public String toString()
        {
            String s = "Name: " + getName();
            return s;
        }

        public void generate()
        {
            throw new NotImplementedException();
        }

        public void prompt()
        {
            throw new NotImplementedException();
        }

        public void print()
        {
            throw new NotImplementedException();
        }
    }
}
