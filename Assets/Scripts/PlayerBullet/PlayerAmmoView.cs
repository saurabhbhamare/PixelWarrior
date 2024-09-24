using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAmmoView : MonoBehaviour
{
    public PlayerAmmoController playerAmmoController;

    public void Update()
    {
        playerAmmoController.UpdatePlayerAmmoMotion();
    }
    public void  SetAmmoController(PlayerAmmoController playerAmmoController)
    {
        this.playerAmmoController = playerAmmoController;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
