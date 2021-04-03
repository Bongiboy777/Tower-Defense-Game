using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using System;

namespace Tests
{
    public class MapLocationTests
    {
        // A Test behaves as an ordinary method
        [Test]
        public void MapLocationOutOfRange()
        {
            Map map = new Map(5, 5);
            Assert.Throws<ArgumentOutOfRangeException>(() => new MapLocation(7,7, map));
            Assert.Throws<ArgumentOutOfRangeException>(() => new MapLocation(100, 0, map));
            Assert.Throws<ArgumentOutOfRangeException>(() => new MapLocation(0,100, map));
            Assert.Throws<ArgumentOutOfRangeException>(() => new MapLocation(0,-3, map));
            Assert.Throws<ArgumentOutOfRangeException>(() => new MapLocation(-3, 0, map));
            Assert.Throws<ArgumentOutOfRangeException>(() => new MapLocation(3, -3, map));
            Assert.Throws<ArgumentOutOfRangeException>(() => new MapLocation(Int32.Parse("61"), Int32.Parse("61"), map));
            Assert.Throws<ArgumentOutOfRangeException>(() => new MapLocation((int)21E8,(int)21E8, map));
            for(short x = 0; x <= map.mapWidth; x++ )
            {
                for (short y = 0; y <= map.mapHeight; y++)
                {
                    Assert.DoesNotThrow(() => new MapLocation(x,y, map));
                }

            }
        }

        [Test]
        public void MapLocationParameterWrongType()
        {
            
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator MapLocationTestsWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
