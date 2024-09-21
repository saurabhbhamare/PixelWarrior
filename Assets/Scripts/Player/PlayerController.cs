using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController
{
    private PlayerView playerView;
    private PlayerModel playerModel;
    BulletPool bulletPool;
    public Bullet bullet;
     
    //  private Rigidbody2D rigidbody;
    public PlayerController(PlayerView playerView, PlayerModel playerModel,Bullet bullet,BulletPool bulletPool)
    {
        this.playerView = playerView;
        this.playerModel = playerModel;
        playerView.SetPlayerController(this);
        this.bullet = bullet;
        bulletPool = new BulletPool(bullet);
        this.bulletPool = bulletPool;
    }
    public void HandlePlayerMovement()
    {
        HandlePlayerAnimations();

        if (playerModel.moveLeft)
        {
            //   playerView.GetAnimator().SetBool("IsRunning", true);
            playerView.transform.Translate(Vector2.left * playerModel.playerSpeed * Time.deltaTime);
            playerView.spriteRenderer.flipX = true;
            // playerView.transform.Rotate(0, 180, 0);
        }

        if (playerModel.moveRIght)
        {
            //   playerView.GetAnimator().SetBool("IsRunning", true);
            playerView.transform.Translate(Vector2.right * playerModel.playerSpeed * Time.deltaTime);
            playerView.spriteRenderer.flipX = false;
            //    playerView.transform.Rotate(0, 0, 0);
        }

        if (playerModel.jump)
        {
           // Debug.Log("running jump");
            playerView.GetRigidBody().AddForce(Vector2.up * playerModel.GetPlayerJumpForce());
            playerModel.jump = false;
        }

    }
    public PlayerModel GetPlayerModel()
    {
        return playerModel;
    }
    public void HandlePlayerInputs()
    {
        if (Input.GetKey(KeyCode.A)) playerModel.moveLeft = true; else playerModel.moveLeft = false;
        if (Input.GetKey(KeyCode.D)) playerModel.moveRIght = true; else playerModel.moveRIght = false;
        if (Input.GetKeyDown(KeyCode.W) && Mathf.Abs(playerView.GetRigidBody().velocity.y) < 0.001) playerModel.jump = true;
        if (Input.GetKeyDown(KeyCode.Space)) FireBullet(bullet);
    }

    public void FlipCharacter()
    {

    }
    public void FireBullet(Bullet bullet)
    {
      //  Debug.Log("running fire bullet function ");
      //  Bullet newBullet = GameObject.Instantiate<Bullet>(bullet);
        Bullet newBullet = bulletPool.GetPooledBullet();
      
        newBullet.transform.position = playerView.bulletSpawnPoint.transform.position;
        Debug.Log("Number of bullets in the pool are" + bulletPool.pooledBullets.Count);

        newBullet.transform.Translate(Vector2.right);

    }
    private void HandlePlayerAnimations()
    {
        if (playerModel.moveRIght || playerModel.moveLeft)
        {
            playerView.GetAnimator().SetBool("IsRunning", true);
        }
        else
        {
            playerView.GetAnimator().SetBool("IsRunning", false);
        }
        if (playerModel.jump)
        {
            playerView.GetAnimator().SetBool("IsJumping", true);
        }
        else
        {
            playerView.GetAnimator().SetBool("IsJumping", false);
        }
      
    }
    public void TakePlayerDamage(float damage)
    {
        playerModel.playerHealth -= damage;
    }
}
