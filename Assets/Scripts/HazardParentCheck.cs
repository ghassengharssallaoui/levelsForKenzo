using UnityEngine;

public class HazardParentCheck : MonoBehaviour
{
   public GameObject level ;
    public Transform Walls;
    [ContextMenu("ChangeHazard")]
    private void ChangeHazardParent()
    {

        // Assuming the script is attached to the "level" GameObject.

        // Find all immediate child GameObjects of "level."
        Transform[] children = new Transform[level.transform.childCount];
        for (int i = 0; i < level.transform.childCount; i++)
        {
            children[i] = level.transform.GetChild(i);
        }

        foreach (Transform child in children)
        {
            if (child.name == "Hazard" && child.parent != null && child.parent.name != "Hazards")
            {
                // Create a new "Hazards" GameObject as a child of "level."
                GameObject hazardsObject = new GameObject("Hazards");
                hazardsObject.transform.SetParent(level.transform);

                // Set the "Hazard" GameObject as a child of the new "Hazards" GameObject.
                child.SetParent(hazardsObject.transform);
            }
        }
    }


    [ContextMenu("ChangepowerUp")]
    private void ChangePowerUpParent()
    {

        // Assuming the script is attached to the "level" GameObject.

        // Find all immediate child GameObjects of "level."
        Transform[] children = new Transform[level.transform.childCount];
        for (int i = 0; i < level.transform.childCount; i++)
        {
            children[i] = level.transform.GetChild(i);
        }

        foreach (Transform child in children)
        {
            if (child.name == "PowerUp" && child.parent != null && child.parent.name != "PowerUps")
            {
                // Create a new "Hazards" GameObject as a child of "level."
                GameObject hazardsObject = new GameObject("PowerUps");
                hazardsObject.transform.SetParent(level.transform);

                // Set the "Hazard" GameObject as a child of the new "Hazards" GameObject.
                child.SetParent(hazardsObject.transform);
            }
        }
    }




    [ContextMenu("RemoveSpaces")]
    private void ChangeNames()
    {
        if (level == null)
        {
            Debug.LogError("Please assign the parent GameObject in the inspector.");
            return;
        }

        // Start the recursive name cleanup.
        CleanChildNames(level.transform);
    }

    private void CleanChildNames(Transform parent)
    {
        foreach (Transform child in parent)
        {
            // Remove trailing spaces from the name.
            string cleanedName = child.name.TrimEnd();

            // Only change the name if it's different from the cleaned name.
            if (child.name != cleanedName)
            {
                // Apply the cleaned name to the GameObject.
                child.name = cleanedName;
            }

            // Recursively clean the names of children.
            CleanChildNames(child);
        }
    }


 

    [ContextMenu("ResetTransform")]
    private void ResetParentTransform()
    {
        if (Walls == null)
        {
            Debug.LogError("Please assign the target transform in the inspector.");
            return;
        }

        // Store the children's positions in world space before resetting.
        Vector3[] childPositions = new Vector3[Walls.childCount];
        for (int i = 0; i < Walls.childCount; i++)
        {
            childPositions[i] = Walls.GetChild(i).position;
        }

        // Reset the target transform.
        Walls.position = Vector3.zero;
        Walls.rotation = Quaternion.identity;
        Walls.localScale = Vector3.one;

        // Restore the children's positions in world space.
        for (int i = 0; i < Walls.childCount; i++)
        {
            Walls.GetChild(i).position = childPositions[i];
        }
    }
}
