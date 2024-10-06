using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryModel 
{
    public bool isInventoryOpened;
    private List<ItemController> itemUISlotList = new List<ItemController>();

    public InventoryModel()
    {
        isInventoryOpened = false;
    }

    public List<ItemController> RetrieveItemControllerList()
    {
        return itemUISlotList;
    }
    // list of inventory items 
}
