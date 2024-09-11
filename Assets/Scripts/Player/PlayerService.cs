using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerService : MonoBehaviour
{
    [SerializeField] private PlayerView playerView;
    private PlayerModel playerModel;
    void Start()
    {
        playerModel = new PlayerModel();
        PlayerController playerController = new PlayerController(playerView, playerModel);
        playerView.SetPlayerController(playerController);
    }
}
