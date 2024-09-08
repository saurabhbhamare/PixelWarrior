using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    private PlayerController playerController;
    void Start()
    {
    }
    void Update()
    {

    }
    public void SetPlayerController(PlayerController playerController)
    {
        this.playerController = playerController;
    }
}
