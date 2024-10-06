using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InventoryView : MonoBehaviour
{
    private InventoryController inventoryController;
    public Transform parentTransform;
    public void SetInventoryController(InventoryController inventoryController)
    {
        this.inventoryController = inventoryController;
    }
    public InventoryController RetrieveInventoryController()
    {
        return inventoryController;
    }
    
}
