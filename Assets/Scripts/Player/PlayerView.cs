using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    private PlayerController playerController;
    [SerializeField] private Rigidbody2D rigidbody;
    [SerializeField] private BoxCollider2D boxCollider;
    [SerializeField] private LayerMask platformLayer;
    [SerializeField] private SpriteRenderer spriteRenderer;

    private bool isOnPlatform;
    void Start()
    {
        
    }
   private void Update()
    {
        //isOnPlatform=  Physics2D.OverlapCircle(transform.position, 0.1f, platformLayer);
        //playerController.GetPlayerModel().SetPlayerStandingState(isOnPlatform);
        playerController.HandlePlayerInputs();
        
        //playerController.HandlePlayerMovement();
    }
    private void FixedUpdate()
    {
        playerController.HandlePlayerMovement();
    }
    public void SetPlayerController(PlayerController playerController)
    {
        this.playerController = playerController;
    }
    public Rigidbody2D GetRigidBody()
    {
        return rigidbody;
    }
}
