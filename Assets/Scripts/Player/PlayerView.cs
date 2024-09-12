using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    private PlayerController playerController;
    [SerializeField] private Rigidbody2D rigidbody;
    [SerializeField] private BoxCollider2D boxCollider;
    [SerializeField] private LayerMask platformLayer;
    [SerializeField] public Bullet bullet;
    public Transform bulletSpawnPoint;
  //  [SerializeField] private SpriteRenderer spriteRenderer;
    public SpriteRenderer spriteRenderer;

    private bool isOnPlatform;
    void Start()
    {
        
    }
   private void Update()
    {
        //isOnPlatform=  Physics2D.OverlapCircle(transform.position, 0.1f, platformLayer);
        //playerController.GetPlayerModel().SetPlayerStandingState(isOnPlatform);
        playerController.HandlePlayerInputs(bullet);
        
        
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
