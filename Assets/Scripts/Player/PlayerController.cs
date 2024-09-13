using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController
{
    private PlayerView playerView;
    private PlayerModel playerModel;
    //  private Rigidbody2D rigidbody;
    public PlayerController(PlayerView playerView, PlayerModel playerModel)
    {
        this.playerView = playerView;
        this.playerModel = playerModel;
        playerView.SetPlayerController(this);
    }
    public void HandlePlayerMovement()
    {
     
        if (playerModel.moveLeft)
        {
            playerView.transform.Translate(Vector2.left * playerModel.playerSpeed * Time.deltaTime);
             playerView.spriteRenderer.flipX = true;
           // playerView.transform.Rotate(0, 180, 0);
        }

        if (playerModel.moveRIght) 
        {
            playerView.transform.Translate(Vector2.right * playerModel.playerSpeed * Time.deltaTime);
              playerView.spriteRenderer.flipX = false;
        //    playerView.transform.Rotate(0, 0, 0);
        }

        if (playerModel.jump)
        {
            Debug.Log("running jump");
            playerView.GetRigidBody().AddForce(Vector2.up * playerModel.GetPlayerJumpForce());
            playerModel.jump = false;
        }

    }
    public PlayerModel GetPlayerModel()
    {
        return playerModel;
    }
    public void HandlePlayerInputs(Bullet bullet)
    {

        if (Input.GetKey(KeyCode.A)) playerModel.moveLeft = true; else playerModel.moveLeft = false;
        if (Input.GetKey(KeyCode.D)) playerModel.moveRIght = true; else playerModel.moveRIght = false;
        if (Input.GetKeyDown(KeyCode.W) && Mathf.Abs(playerView.GetRigidBody().velocity.y) < 0.001) playerModel.jump = true;
        if (Input.GetKey(KeyCode.Space)) FireBullet(bullet);
    }
  
    public void FlipCharacter()
    {

    }
    public void FireBullet(Bullet bullet)
    {
        Debug.Log("running fire bullet function ");
        Bullet newBullet = GameObject.Instantiate<Bullet>(bullet);
      //  newBullet.transform.position = playerView.bulletSpawnPoint.transform.position;
       // newBullet.transform.Translate(Vector2.right);
       
    }
}
