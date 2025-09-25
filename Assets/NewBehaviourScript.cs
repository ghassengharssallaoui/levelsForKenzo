using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string objectNameToFind = "ObjectName";
    public string newName = "NewName";

    public void RenameObject()
    {
        GameObject objectToRename = GameObject.Find(objectNameToFind);

        if (objectToRename != null)
        {
            objectToRename.name = newName;
        }
        else
        {
            Debug.LogWarning("Object not found with the name: " + objectNameToFind);
        }
    }



    // Add a new method to call RenameObject during Edit mode.
    [ContextMenu("Rename Selected Object")]
    private void RenameObjectInEditMode()
    {
        RenameObjectsWithSameName();
    }

    public void RenameObjectsWithSameName()
    {
        GameObject[] allObjects = GameObject.FindObjectsOfType<GameObject>();

        Dictionary<string, string> nameMappings = new Dictionary<string, string>
{
    { "collectible", "Collectible" },
    { "collectible (1)", "Collectible" },
    { "collectible (2)", "Collectible" },
    { "enemy", "Enemy" },
    { "Buttom", "Bottom" },
    { "Platform (2)", "Platform" },
    { "Platform (1)", "Platform" },
    { "Platform (3)", "Platform" },
    { "Platform (4)", "Platform" },
    { "Platform (5)", "Platform" },
    { "Removable", "RemovableRegion" },
    { "platform", "Platform" },
    { "enemy (1)", "Enemy" },
    { "enemy (2)", "Enemy" },
    { "Platform  (1)", "Platform" },
    { "Hazard (1)", "Hazard" },
    { "Collectible (1)", "Collectible" },
    { "collectibles", "Collectibles" },
    { "enemy (3)", "Enemy" },
    { "enemy (4)", "Enemy" },
    { "Ground", "Platform" },
    { "Ground (1)", "Platform" },
    { "Ground (2)", "Platform" },
    { "Platform  (2)", "Platform" },
    { "Enemy (1)", "Enemy" },
    { "Enemy (2)", "Enemy" },
    { "Enemy (3)", "Enemy" },
    { "Enemy (4)", "Enemy" },
    { "Enemy (5)", "Enemy" },
    { "Enemy (6)", "Enemy" },
    { "Ground (3)", "Platform" },
    { "Ground (4)", "Platform" },
    { "Ground (5)", "Platform" },
    { "Ground (6)", "Platform" },
    { "Ground (7)", "Platform" },
    { "Ground (8)", "Platform" },
    { "Ground (9)", "Platform" },
    { "Ground (10)", "Platform" },
    { "Ground (11)", "Platform" },
    { "Ground (12)", "Platform" },
    { "Ground (13)", "Platform" },
    { "Ground (14)", "Platform" }
};
        for (int i = 0; i <= 50; i++)
        {
            nameMappings[$"Ground ({i})"] = "Platform";
        }
        for (int i = 0; i <= 50; i++)
        {
            nameMappings[$"Platform ({i})"] = "Platform";
        }

        // Iterate through all objects and update their names based on the dictionary
        foreach (GameObject obj in allObjects)
        {
            if (nameMappings.ContainsKey(obj.name))
            {
                obj.name = nameMappings[obj.name];
            }
        }
    }



}
