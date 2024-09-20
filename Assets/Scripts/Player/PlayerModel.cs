using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel
{
    private float jumpForce;
    public float playerSpeed;
    public bool moveRIght;
    public bool moveLeft;
    public bool jump;
    public float playerHealth = 100;
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
