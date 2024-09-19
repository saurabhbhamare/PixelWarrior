using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerService 
{
    // [SerializeField] private PlayerView playerView;
    private PlayerView playerView;
    private PlayerModel playerModel;
    //private PlayerController playerController;

    public PlayerService(PlayerView playerView)
    {
        this.playerView = playerView;
        playerModel = new PlayerModel();
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
        PlayerController playerController = new PlayerController(playerView, playerModel);
        playerView.SetPlayerController(playerController);
    }
}
