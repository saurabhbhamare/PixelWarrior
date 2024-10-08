using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryService : MonoBehaviour
{
    private InventoryView inventoryView;
    private InventoryController inventoryController;
    private ItemView ItemView;
    
    public InventoryService(InventoryView inventoryView,ItemView itemView)
    {
        this.inventoryView = inventoryView;
        this.ItemView = itemView;
        InventoryModel inventoryModel = new InventoryModel();
        inventoryController = new InventoryController(inventoryView, inventoryModel,itemView);
        inventoryView.SetInventoryController(inventoryController);
        
    }
}
