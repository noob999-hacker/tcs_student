using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    public List<Item>items = new List<Item>();
    public void Addition (Item newItem){
        items.Add(newItem);
        Debug.Log($"Added{newItem.itemName}to inventory");
        
        








    }

}
