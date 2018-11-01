using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorldApp
{
    class Cell
    {
        private int x;
        private int y;

        public Cell(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int getX()
        {
            return this.x;
        }
        public int getY()
        {
            return this.y;
        }

        public bool Equals(Cell obj)
        {
            if (getX() == obj.getX() && getY()==obj.getY())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
