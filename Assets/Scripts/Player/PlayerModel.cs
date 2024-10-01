using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel
{
    public float moveSpeed;
 //   public bool moveRIght;
 //   public bool moveLeft;
    public float jumpForce;
    public float playerHealth;
    public bool isJumping;
    public bool isPlatformed;
    public bool isFacingDef;
    public float platformDetLength;
    public int ammoStock;
    //public Vector2 playerSize;
 
    
    // public BulletPool bulletPool;

    public PlayerModel()
    {
        //  bulletPool = new BulletPool();
        playerHealth = 100f;
        moveSpeed = 6f;
        jumpForce = 30f;
       // playerSize = new Vector2(0.6f, 0.6f);
        isFacingDef = true;
        platformDetLength = 0.2f;
        ammoStock = 10;

      //  playerFaceDirection = PlayerFaceDirection.RIGHT;
    }
    public float GetPlayerJumpForce()
    {
        return jumpForce;
    }
    public enum PlayerFaceDirection
    {
        LEFT,
        RIGHT
    }
}

