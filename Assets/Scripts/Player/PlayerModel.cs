using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel 
{
    public float playerSpeed;
    private float jumpForce;
    public bool moveRIght;
    public bool moveLeft;
    public bool jump;
   // public BulletPool bulletPool;

    public PlayerModel()
    {
      //  bulletPool = new BulletPool();
        playerSpeed = 6f;
        jumpForce = 430f;
    }
    public float GetPlayerJumpForce()
    {
        return jumpForce; 
    }

}