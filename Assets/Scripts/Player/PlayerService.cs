//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class PlayerService 
{
    private PlayerView playerView;
    private PlayerModel playerModel;
    private PlayerAmmoView playerAmmoView;
    public static PlayerController playerController;
    private PlayerAmmoPool playerAmmoPool;
    private PlayerUIController playerUIController;
    private InventoryView inventoryView;
    

    public PlayerService(PlayerView playerView, PlayerAmmoView playerAmmoView,PlayerUIController playerUIController,InventoryView inventoryView)
    {
        this.inventoryView = inventoryView;
        this.playerView = playerView;
        this.playerAmmoView = playerAmmoView;
        playerModel = new PlayerModel();
        this.playerAmmoPool = new PlayerAmmoPool(playerAmmoView);
        this.playerUIController = playerUIController;

        InitializePlayer();
        
    }
    private void InitializePlayer()
    {
         playerController = new PlayerController(playerView, playerModel,playerAmmoPool,playerUIController,inventoryView);
         playerView.SetPlayerController(playerController);
    }
    
}
