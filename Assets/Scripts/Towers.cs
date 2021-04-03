using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    class MagicTower : ITower
    {
        public int Health { get; set; } = 5;
        public int Power { get; set; } = 5;
        public int Range { get; set; } = 5;
    }

    class SniperTower : ITower
    {
        public int Health { get; set; } = 5;
        public int Power { get; set; } = 10;
        public int Range { get; set; } = 3;
    }

    class FastTower : ITower
    {
        public int Health { get; set; } = 5;
        public int Power { get; set; } = 2;
        public int Range { get; set; } = 10;
    }

    class CanonTower : ITower
    {
        public int Health { get; set; } = 20;
        public int Power { get; set; } = 10;
        public int Range { get; set; } = 2;
    }
}
