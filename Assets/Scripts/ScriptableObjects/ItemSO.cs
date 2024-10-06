using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "ItemSO", menuName = "CreateScriptableObject/Item/ItemSO")]
public class ItemSO : ScriptableObject
{
    public string itemName;
    public Sprite itemSprite;
    public ItemType itemType;
  //  public int itemQuantity;
}
