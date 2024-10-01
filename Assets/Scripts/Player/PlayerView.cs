using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    private PlayerController playerController;
    private BoxCollider2D boxCollider;
    private Animator animator;
    public Rigidbody2D rigidbody;
    public Transform ammoSpawnPoint;
    public LayerMask layerMask;
    public Vector2 playerSize;

    private bool isOnPlatform;
    void Start()
    {
        playerSize = new Vector2(0.6f, 0.6f);
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        playerController.HandlePlayerInputs();
    }
    private void FixedUpdate()
    {
        playerController.HandlePlayerAnimations();
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<StingerBullet>())
        {
            playerController.TakePlayerDamage(20);
            playerController.playerUIController.UpdateHealthBarUIAfterTakingDamage(20f);
        }
    }
}
