using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerService 
{
    // [SerializeField] private PlayerView playerView;
    private PlayerView playerView;
    private PlayerModel playerModel;
    private Bullet bullet;
    public PlayerController playerController;
    private BulletPool bulletPool;

    public PlayerService(PlayerView playerView,Bullet bullet,BulletPool bulletPool)
    {
        this.playerView = playerView;
        this.bullet = bullet;
        this.bulletPool = bulletPool;

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
         playerController = new PlayerController(playerView, playerModel,bullet,bulletPool);
         playerView.SetPlayerController(playerController);
    }
    
}
