using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public byte mapWidth;
    public byte mapHeight;
    public Map(byte width, byte height)
    {
        mapWidth = width;
        mapHeight = height;
    }
}
