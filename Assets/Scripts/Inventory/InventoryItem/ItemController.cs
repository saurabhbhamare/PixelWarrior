using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController 
{
    private ItemView itemView;
    public int itemQuantity;
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

}
