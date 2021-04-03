using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    class BasicInvader: IInvader
    {
        public MapLocation currentTarget => GetTarget(new Map(4, 4));
        public MapLocation GetTarget(Map map)
        {
            return new MapLocation(0, 0, map);
        }
        public int Health { get; set; } = 5;
        public int Power { get; set; }  = 5;
        public int Speed { get; set; }  = 5;
        public BasicInvader()
        {

        }
    }

    class BruteInvader : IInvader
    {
        public MapLocation currentTarget => GetTarget(new Map(4, 4));
        public MapLocation GetTarget(Map map)
        {
            return new MapLocation(0, 0, map);
        }
        public int Health { get; set; } = 5;
        public int Power { get; set; } = 10;
        public int Speed { get; set; } = 3;

        public BruteInvader()
        {

        }
    }
    class FastInvader : IInvader
    {
        public MapLocation currentTarget => GetTarget(new Map(4, 4));
        public MapLocation GetTarget(Map map)
        {
            return new MapLocation(0, 0, map);
        }
        public int Health { get; set; } = 5;
        public int Power { get; set; } = 2;
        public int Speed { get; set; } = 10;

        public FastInvader()
        {

        }
    }

    class BossInvader : IInvader
    {
        public MapLocation currentTarget  => GetTarget(new Map(4,4));
        public MapLocation GetTarget(Map map)
        {
            return new MapLocation(0, 0, map);
        }
        public int Health { get; set; } = 20;
        public int Power { get; set; } = 10;
        public int Speed { get; set; } = 2;
        public BossInvader()
        {

        }
    }
}
