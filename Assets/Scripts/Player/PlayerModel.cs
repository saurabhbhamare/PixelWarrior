//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

public class PlayerModel
{
    public float horizontalInput;
    public float verticalInput;
    public float moveSpeed;
    public float jumpForce;
    public float playerHealth;
    public bool isJumping;
    public bool isUsingVine;
    public bool isPlatformed;
    public bool isFacingDef;   // Is Player Facing Default Direction 
    public float platformDetLength;
    public int ammoStock;
    public bool isReloadingWeapon;
    public float reloadingTime;
    public int maxAmmo;
    public float vineMoveSpeed;
    public float defaultGravityScale; 
    public PlayerModel()
    {
        playerHealth = 100f;
        moveSpeed = 6f;
        jumpForce = 30f;
        isFacingDef = true;
        platformDetLength = 0.2f;
        maxAmmo = 10; 
        ammoStock = 10;
        reloadingTime = 2f;
        vineMoveSpeed = 4f;
        defaultGravityScale = 3f;
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

