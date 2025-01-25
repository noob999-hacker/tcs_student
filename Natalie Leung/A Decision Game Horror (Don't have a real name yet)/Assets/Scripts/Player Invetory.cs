using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInvetory : MonoBehaviour
{
    private List <Item> items = new List<Item>();
    public void Add_Item(Item item)
    {
        items.Add(item);
            Debug.Log($"Added new item!");
    }

}
    