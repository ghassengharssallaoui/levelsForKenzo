using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RoomObjectType
{
    Collectible,
    Hazard,
    Enemy,
    Powerup,
    Terrain,
    RemovableRegion,
    Door,
    Wall
}

public class RoomObject : MonoBehaviour
{
    public RoomObjectType roomObjectType;
}
