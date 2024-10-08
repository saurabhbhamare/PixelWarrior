using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController 
{
    private ItemView itemView;
    public string itemName;
    public int itemQuantity;
    public ItemSO itemSO;
    //public ItemController(ItemView itemView)
    //{
    //    this.itemView = itemView;
    //}  
    public ItemController()
    {
        
    }

    public void SetItemView(ItemView itemView)
    {
        this.itemView = itemView;
    }
    public void SetItemData(ItemSO itemSO)
    {
        this.itemSO = itemSO;
    }

}
