using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerService 
{
    // [SerializeField] private PlayerView playerView;
    private PlayerView playerView;
    private PlayerModel playerModel;
    private PlayerAmmoView playerAmmoView;
    public static PlayerController playerController;
    private PlayerAmmoPool playerAmmoPool;
    private PlayerUIController playerUIController;
    

    public PlayerService(PlayerView playerView, PlayerAmmoView playerAmmoView,PlayerUIController playerUIController)
    {
        this.playerView = playerView;
        this.playerAmmoView = playerAmmoView;
        playerModel = new PlayerModel();
        this.playerAmmoPool = new PlayerAmmoPool(playerAmmoView);
        this.playerUIController = playerUIController;

        InitializePlayer();
        
    }

    //void Start()
    //{
    //    playerModel = new PlayerModel();
    //    PlayerController playerController = new PlayerController(playerView, playerModel);
    //    playerView.SetPlayerController(playerController);
    //}

    private void InitializePlayer()
    {
         playerController = new PlayerController(playerView, playerModel,playerAmmoPool,playerUIController);
         playerView.SetPlayerController(playerController);
    }
    
}
