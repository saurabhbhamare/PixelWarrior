using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAmmoController
{
    public PlayerAmmoView playerAmmoView;
    public float ammoSpeed = 1f;
    public PlayerAmmoController(PlayerAmmoView playerAmmoView)
    {
        this.playerAmmoView = Object.Instantiate(playerAmmoView);
        this.playerAmmoView.SetAmmoController(this);
    }
    public void SetAmmo(Transform ammoTransform)
    {
        playerAmmoView.gameObject.SetActive(true);
        playerAmmoView.gameObject.transform.position = ammoTransform.position;
        playerAmmoView.gameObject.transform.rotation = ammoTransform.rotation;
    }
    public void UpdatePlayerAmmoMotion()
    {
        playerAmmoView.transform.Translate(Vector2.right * ammoSpeed * Time.deltaTime);
    }
    public void HandleCollision()
    {
        playerAmmoView.gameObject.SetActive(false);
        

    }
}
