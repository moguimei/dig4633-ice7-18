using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemPlacer : MonoBehaviour
{
    // Event to be called after items are placed
    [System.Serializable]
    public class ItemPlacedEvent : UnityEvent { }
    public ItemPlacedEvent onItemsPlaced;

    // Function to place an item
    public void PlaceItem(GameObject item)
    {
        if (item.layer == LayerMask.NameToLayer("YellowBlue"))
        {
            // Your logic to place the item in the scene, e.g., instantiate it
            Debug.Log($"Placing item: {item.name}");

            // Optionally set the position or parent of the item here
            item.transform.position = transform.position; // Example of placing it at the current object's position
            item.SetActive(true); // Activate the item if it was inactive

            // Call the event
            onItemsPlaced.Invoke();
            Debug.Log("Items placed. Event invoked.");
        }
        else
        {
            Debug.LogWarning("Item is not on the YellowBlue layer!");
        }
    }
}

