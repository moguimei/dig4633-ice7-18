using UnityEngine;

using UnityEngine;

public class chelle_script_2 : MonoBehaviour
{
    public chelle_script slotChecker; // Reference to the slot checker script
    public GameObject item1GameObject; // Item to place in Slot 1
    public GameObject item2GameObject; // Item to place in Slot 2

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) // Simulate placing an item in Slot 1
        {
            slotChecker.PlaceItemInSlot1(item1GameObject);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2)) // Simulate placing an item in Slot 2
        {
            slotChecker.PlaceItemInSlot2(item2GameObject); 
        }
    }
}
