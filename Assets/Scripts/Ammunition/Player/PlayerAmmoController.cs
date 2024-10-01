using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAmmoController
{
    public PlayerAmmoView playerAmmoView;
    public float ammoSpeed = 8f;
    public bool movedirDef;
    public Transform ammoSpawnPoint;
    private PlayerAmmoPool playerAmmoPool;
    private PlayerModel playerModel;
    public PlayerAmmoController(PlayerAmmoView playerAmmoView)
    {
        this.playerAmmoView = Object.Instantiate(playerAmmoView);
        this.playerAmmoView.SetAmmoController(this);
      
        
    }
    public void SetAmmo(Transform ammoTransform,PlayerAmmoPool playerAmmoPool,bool movedir)
    {
        playerAmmoView.gameObject.SetActive(true);
        this.playerAmmoPool = playerAmmoPool;
        playerAmmoView.gameObject.transform.position = ammoTransform.position;
        playerAmmoView.gameObject.transform.rotation = ammoTransform.rotation;
        this.movedirDef = movedir;
        
    }
    public void UpdatePlayerAmmoMotion()
    {
        if(movedirDef)
        {
            playerAmmoView.transform.Translate(Vector2.right * ammoSpeed * Time.deltaTime);
        }
        else
        {
            playerAmmoView.transform.Translate(Vector2.left * ammoSpeed * Time.deltaTime);
        }
    }
    public void HandleCollision()
    {
        playerAmmoView.gameObject.SetActive(false);
        playerAmmoPool.ReturnItem(this);

    }
}