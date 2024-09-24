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

    public PlayerService(PlayerView playerView, PlayerAmmoView playerAmmoView)
    {
        this.playerView = playerView;
        this.playerAmmoView = playerAmmoView;
        playerModel = new PlayerModel();
        this.playerAmmoPool = new PlayerAmmoPool(playerAmmoView);  

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
         playerController = new PlayerController(playerView, playerModel,playerAmmoPool);
         playerView.SetPlayerController(playerController);
    }
    
}
