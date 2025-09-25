using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(RoomObject))]
public class RoomObjectEditor : Editor
{


    private RoomObjectType DetermineRoomObjectType(string objectName, string parentName)
    {
        if (parentName == "Doors" || parentName == "Doors ")
        {
            return RoomObjectType.Door;
        }
        else if (parentName == "Walls" || parentName == "Walls ")
        {
            return RoomObjectType.Wall;
        }

        switch (objectName)
        {
            case "Hazard":
                return RoomObjectType.Hazard;
            case "Enemy":
                return RoomObjectType.Enemy;
            case "PowerUp":
                return RoomObjectType.Powerup;
            case "Platform":
                return RoomObjectType.Terrain;

            case "Platform ":
                return RoomObjectType.Terrain;


            case "RemovableRegion":
                return RoomObjectType.RemovableRegion;
            case "Bottom":
                return RoomObjectType.Wall;
            case "Down":
                return RoomObjectType.Door;
            default:
                return RoomObjectType.Collectible;
        }
    }

    public override void OnInspectorGUI()
    {
        RoomObject roomObject = (RoomObject)target;
        string objectName = roomObject.gameObject.name;
        string parentName = roomObject.gameObject.transform.parent != null ? roomObject.gameObject.transform.parent.name : "";

        roomObject.roomObjectType = DetermineRoomObjectType(objectName, parentName);

        base.OnInspectorGUI();
    }

}
