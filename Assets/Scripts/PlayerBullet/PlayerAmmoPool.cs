using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAmmoPool : ResourcePool<PlayerAmmoController>
{
    public PlayerAmmoView playerAmmoView;

    public PlayerAmmoPool(PlayerAmmoView playerAmmoView)
    {
        this.playerAmmoView = playerAmmoView;
    }
    public PlayerAmmoController RetrieveAmmo() => RetrieveItem();
    protected override PlayerAmmoController InitializeItem() => new PlayerAmmoController(playerAmmoView);
    public void ShowAmmo()
    {
        Debug.Log("ammo");
    }

}
