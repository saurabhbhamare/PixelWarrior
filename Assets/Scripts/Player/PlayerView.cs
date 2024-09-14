using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    private PlayerController playerController;
    private Rigidbody2D rigidbody;
    private BoxCollider2D boxCollider;
    [SerializeField] public Bullet bullet;
    [SerializeField] private GameObject gameOverScreen;
    public SpriteRenderer spriteRenderer;

    private bool isOnPlatform;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
   private void Update()
    {
        playerController.HandlePlayerInputs(bullet);
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.name == "EkansVisual")
        {
            Time.timeScale = 0;
            gameOverScreen.SetActive(true);
        }
       if(collision.gameObject.name == "Door")
        {
            Debug.Log("collided with door");
        }
    }
}
