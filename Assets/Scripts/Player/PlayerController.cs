using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController
{
    private PlayerView playerView;
    private PlayerModel playerModel;
    public PlayerAmmoPool playerAmmoPool;
  

    private float horizontalInput;
     
    //  private Rigidbody2D rigidbody;
    public PlayerController(PlayerView playerView, PlayerModel playerModel ,PlayerAmmoPool playerAmmoPool)
    {
        this.playerView = playerView;
        this.playerModel = playerModel;
        playerView.SetPlayerController(this);
        this.playerAmmoPool = playerAmmoPool;
    }
    public void HandlePlayerMovement()
    {
        HandlePlayerAnimations();

        //if (playerModel.moveLeft)
        //{
        //    // playerView.transform.Rotate(0, 180, 0);
        //    playerView.transform.localScale = new Vector3(-1, 1, 1);
        //    //   playerView.GetAnimator().SetBool("IsRunning", true);
        //    playerView.transform.Translate(Vector2.left * playerModel.playerSpeed * Time.deltaTime);

        //  //  playerView.spriteRenderer.flipX = true;


        //}

        //if (playerModel.moveRIght)
        //{

        //    // playerView.transform.Rotate(0, 0, 0);
        //    playerView.transform.localScale = new Vector3(1, 1, 1);
        //    //   playerView.GetAnimator().SetBool("IsRunning", true);
        //    playerView.transform.Translate(Vector2.right * playerModel.playerSpeed * Time.deltaTime);
        //    //playerView.spriteRenderer.flipX = false;
        //}

        //if (playerModel.jump)
        //{
        //   // Debug.Log("running jump");
        //    playerView.GetRigidBody().AddForce(Vector2.up * playerModel.GetPlayerJumpForce());
        //    playerModel.jump = false;
        //}


        // physics based movement
        playerView.rigidbody.velocity = new Vector2(horizontalInput * playerModel.moveSpeed, playerView.rigidbody.velocity.y);
        if(horizontalInput > 0.01)
        {
            playerView.transform.localScale = new Vector3(1, 1, 1);
        }
        else if(horizontalInput < -0.01)
        {
            playerView.transform.localScale = new Vector3(-1, 1, 1);
        }
        
        if(playerModel.isJumping )
        {
            //playerView.rigidbody.velocity = new Vector2(playerView.rigidbody.velocity.x, playerModel.moveSpeed);
            playerView.rigidbody.AddForce(Vector2.up * playerModel.jumpForce, ForceMode2D.Impulse);

        }

    }
    public PlayerModel GetPlayerModel()
    {
        return playerModel;
    }
    public void HandlePlayerInputs()
    {
        //if (Input.GetKey(KeyCode.A)) playerModel.moveLeft = true; else playerModel.moveLeft = false;
        //if (Input.GetKey(KeyCode.D)) playerModel.moveRIght = true; else playerModel.moveRIght = false;
        //if (Input.GetKeyDown(KeyCode.W) && Mathf.Abs(playerView.GetRigidBody().velocity.y) < 0.001) playerModel.jump = true;
        //if (Input.GetKeyDown(KeyCode.Space)) FireBullet(bullet);

        // Physics based movement
        horizontalInput = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.W) && Mathf.Abs(playerView.GetRigidBody().velocity.y) < 0.001) playerModel.isJumping = true; else playerModel.isJumping = false;
        if (Input.GetKeyDown(KeyCode.Space)) FireBullet();
    }

    public void FlipCharacter()
    {

    }
    public void FireBullet()
    {

        PlayerAmmoController playerAmmo = playerAmmoPool.RetrieveAmmo();
        //playerAmmoPool.ShowAmmo();
        playerAmmo.SetAmmo(playerView.bulletSpawnPoint);
      
        
      //  newBullet.ConfigureBullet(playerModel.moveRIght, playerModel.moveLeft);
   
        //if(playerModel.moveLeft)
        //{
        //  //  newBullet.transform.Translate(Vector2.left);
        //    Debug.Log("move bullet to the left running ");
        //}
        //else if(playerModel.moveRIght)
        //{
        //    newBullet.transform.Translate(Vector2.right);
        //}
    

    }
    private void HandlePlayerAnimations()
    {
        //if (playerModel.moveRIght || playerModel.moveLeft)
        //{
        //    playerView.GetAnimator().SetBool("IsRunning", true);
        //}
        //else
        //{
        //    playerView.GetAnimator().SetBool("IsRunning", false);
        //}
        //if (playerModel.jump)
        //{
        //    playerView.GetAnimator().SetBool("IsJumping", true);
        //}
        //else
        //{
        //    playerView.GetAnimator().SetBool("IsJumping", false);
        //}

        if(horizontalInput!=0)
        {
            playerView.GetAnimator().SetBool("IsRunning", true);
        }
        else
        {
            playerView.GetAnimator().SetBool("IsRunning", false);
        }
    }
    public void TakePlayerDamage(float damage)
    {
        playerModel.playerHealth -= damage;
    }
}
