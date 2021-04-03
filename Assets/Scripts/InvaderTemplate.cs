using System;
using System.Collections.Generic;
using System.Text;

interface IInvader
{
    MapLocation GetTarget(Map map);
    MapLocation currentTarget { get;}
    int Health { get; set; }
    int Power { get; set; }
    int Speed { get; set; }
}
