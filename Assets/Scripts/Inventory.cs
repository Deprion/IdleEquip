using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance;
    public CellItem[] EquipedItem = new CellItem[5];
    public Item[] InventoryItem = new Item[100];
    private void Start()
    {
        Instance = this;
    }
    public void DeleteItem(Item item)
    { 
        
    }
    public void DeleteItem(Item[] itemArray)
    {
        foreach (Item item in itemArray)
        {
            DeleteItem(item);
        }
    }
}
