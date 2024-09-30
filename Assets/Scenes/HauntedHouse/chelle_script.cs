using UnityEngine;
using UnityEngine.Events;

public class chelle_script : MonoBehaviour
{
    public GameObject correctItem1; // The correct item for Slot 1
    public GameObject correctItem2; // The correct item for Slot 2
    public UnityEvent onCorrectItemsPlaced; // UnityEvent to trigger when both items are correct

    private GameObject slot1Item;
    private GameObject slot2Item;

    public void PlaceItemInSlot1(GameObject item)
    {
        slot1Item = item;
        CheckSlots();
    }

    public void PlaceItemInSlot2(GameObject item)
    {
        slot2Item = item;
        CheckSlots();
    }

    private void CheckSlots()
    {
        if (slot1Item == correctItem1 && slot2Item == correctItem2)
        {
            onCorrectItemsPlaced.Invoke();
            // Optionally, reset the slots
            ResetSlots();
        }
    }

    private void ResetSlots()
    {
        slot1Item = null;
        slot2Item = null;
    }
}
