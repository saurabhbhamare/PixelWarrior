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
        //playerModel.IsPlayerStandingOnPlatform() = playerView.GetRigidBody

        // if(Input.GetKey(KeyCode.D)) playerView.transform.Translate(Vector2.right * playerModel.playerSpeed * Time.deltaTime);
        //   if(Input.GetKey(KeyCode.A)) playerView.transform.Translate(Vector2.left * playerModel.playerSpeed * Time.deltaTime);
        // if (Input.GetKey(KeyCode.Space)) rigidbody.AddForce(Vector2.up* 20);
        //  if (Input.GetKeyDown(KeyCode.Space) && playerModel.IsPlayerStandingOnPlatform()) playerView.GetRigidBody().AddForce(Vector2.up*playerModel.GetPlayerJumpForce());
        if (playerModel.moveLeft) playerView.transform.Translate(Vector2.left * playerModel.playerSpeed * Time.deltaTime);
        if (playerModel.moveRIght) playerView.transform.Translate(Vector2.right * playerModel.playerSpeed * Time.deltaTime);
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
    public void HandlePlayerInputs()
    {
        if (Input.GetKey(KeyCode.A)) playerModel.moveLeft = true; else playerModel.moveLeft = false;
        if (Input.GetKey(KeyCode.D)) playerModel.moveRIght = true; else playerModel.moveRIght = false;
        if (Input.GetKeyDown(KeyCode.W) && Mathf.Abs(playerView.GetRigidBody().velocity.y) < 0.001) playerModel.jump = true;
    }
    public bool isPlPlatformed()
    {
        return playerModel.isPlatformed;
    }

}
