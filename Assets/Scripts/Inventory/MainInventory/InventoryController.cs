using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController
{
    public InventoryView inventoryView;
    public InventoryModel inventoryModel;
    private ItemView itemView;
    public InventoryController(InventoryView inventoryView, InventoryModel inventoryModel,ItemView itemView)
    {
        this.inventoryView = inventoryView;
        this.inventoryModel = inventoryModel;
        this.itemView = itemView;
    }
    public void ShowInventory()
    {
        inventoryView.gameObject.SetActive(true);
    }
    public void HideInventory()
    {
        inventoryView.gameObject.SetActive(false);
    }
    public void AddItemTotheInventory(ItemController item)
    {
        ItemView tempItemView = GameObject.Instantiate<ItemView>(itemView);
        tempItemView.gameObject.SetActive(true);
        tempItemView.transform.SetParent(inventoryView.parentTransform);
        item.SetItemView(tempItemView);
        inventoryModel.RetrieveItemControllerList().Add(item);
        Debug.Log(inventoryModel.RetrieveItemControllerList().Count);
    }
  
    public void RemoveItemFromTheInventory()
    {

    }
    public void InventoryVisibility()
    {
        if(inventoryModel.isInventoryOpened)
        {
            ShowInventory();
        }
        else
        {
            HideInventory();
        }
    }
    //public bool IsInventoryItemAlreadyPresent(ItemController item)
    //{
    //    foreach (ItemController tempItem in inventoryModel.RetrieveItemControllerList())
    //    {
    //        if (item == tempItem)
    //        {
    //            return true;
    //        }
    //    }
    //    return false;
    //}
}
