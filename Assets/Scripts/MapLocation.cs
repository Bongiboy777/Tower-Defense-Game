using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class MapLocation: Point
    {
        public int xCoord;
        public int yCoord;
        public MapLocation(int x, int y, Map map): base(x,y)
        {
            if(x <= map.mapHeight && x >= 0 && y <= map.mapHeight && y >= 0)
            {
                xCoord = x;
                yCoord = y;

            }

            else
            {
                throw (new System.ArgumentOutOfRangeException());
            }
        }
    }

