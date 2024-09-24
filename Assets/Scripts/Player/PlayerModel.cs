using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel
{
    public float moveSpeed;
    public bool moveRIght;
    public bool moveLeft;
    public float jumpForce;
    public float playerHealth = 100;
    public bool isJumping;
    public bool isPlatformed;
    // public BulletPool bulletPool;

    public PlayerModel()
    {
        //  bulletPool = new BulletPool();
        moveSpeed = 6f;
        jumpForce = 10f;
    }
    public float GetPlayerJumpForce()
    {
        return jumpForce;
    }

}
