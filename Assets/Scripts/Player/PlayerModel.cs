using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel 
{
    public float playerSpeed;
    private float playerHealth;
    private bool isPlayerMoving;
    private float jumpForce;
    public  bool isPlatformed;
    public bool moveRIght;
    public bool moveLeft;
    public bool jump;

    public PlayerModel()
    {
        playerSpeed = 6f;
        jumpForce = 450f;
    }
    public bool IsPlayerMoving()
    {
        return isPlayerMoving;
    }
    public float GetPlayerJumpForce()
    {
        return jumpForce; 
    }
    public bool IsPlayerStandingOnPlatform()
    {
        return isPlatformed;
    }
    public void SetPlayerStandingState(bool state)
    {
        isPlatformed = state;
    }
}
