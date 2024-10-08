using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ItemVisual : MonoBehaviour
{
    // public Image itemImage;
    private SpriteRenderer spriteRenderer;
   // public TextMeshProUGUI quantityText;
    private ItemController itemController;
    // private string itemName;
    [SerializeField] private ItemSO itemDataSO;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = itemDataSO.itemSprite;
        itemController = new ItemController();
        itemController.SetItemData(itemDataSO);
        
    }
    public ItemVisual()
    {
       
        
    }
    public ItemSO RetrieveItemSO()
    {
        return itemDataSO;
    }
    public ItemController RetrieveItemController()
    {
        return itemController;
    }
   
}
