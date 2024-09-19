using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    private PlayerController playerController;
    private Rigidbody2D rigidbody;
    private BoxCollider2D boxCollider;
    public SpriteRenderer spriteRenderer;
    private Animator animator;
    public Transform bulletSpawnPoint;

    private bool isOnPlatform;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }
   private void Update()
    {
        playerController.HandlePlayerInputs();
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
    public Animator GetAnimator()
    {
        return animator;
    }
}
