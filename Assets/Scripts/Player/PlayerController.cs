using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController
{
    private PlayerView playerView;
    private PlayerModel playerModel;
    public PlayerAmmoPool playerAmmoPool;
    public PlayerUIController playerUIController;
    private InventoryView inventoryView;
    private InventoryService inventoryService;
    private float horizontalInput;
    public float verticalInput;

    //  private Rigidbody2D rigidbody;
    public PlayerController(PlayerView playerView, PlayerModel playerModel, PlayerAmmoPool playerAmmoPool, PlayerUIController playerUIController, InventoryView inventoryView)
    {
        this.inventoryView = inventoryView;
        this.playerView = playerView;
        this.playerModel = playerModel;
        playerView.SetPlayerController(this);
        this.playerAmmoPool = playerAmmoPool;
        this.playerUIController = playerUIController;
    }
    public void HandlePlayerMovement()
    {
        // physics based movement
        playerView.rigidbody.velocity = new Vector2(horizontalInput * playerModel.moveSpeed, playerView.rigidbody.velocity.y);
        if (horizontalInput > 0.01)
        {
            playerView.transform.localScale = new Vector3(1, 1, 1);
            playerModel.isFacingDef = true;
        }
        else if (horizontalInput < -0.01)
        {
            playerView.transform.localScale = new Vector3(-1, 1, 1);
            playerModel.isFacingDef = false;
        }

        if (playerModel.isJumping)
        {
            Debug.Log("running jump logic");
            playerView.rigidbody.velocity = new Vector2(playerView.rigidbody.velocity.x, 0);
            playerView.rigidbody.AddForce(Vector2.up * playerModel.jumpForce, ForceMode2D.Impulse);
            playerModel.isJumping = false;
        }

        if (playerModel.isUsingVine)
        {
            playerView.rigidbody.gravityScale = 0f;
            playerView.rigidbody.velocity = new Vector2(playerView.rigidbody.velocity.x, playerModel.vineMoveSpeed * verticalInput);
        }
        else
        {
            playerView.rigidbody.gravityScale = playerModel.defaultGravityScale;
        }

    }
    public PlayerModel GetPlayerModel()
    {
        return playerModel;

    }
    public void HandlePlayerInputs()
    {
        playerModel.isPlatformed = IsPlatformed();
        // Physics based movement
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //  if (Input.GetKeyDown(KeyCode.W) && Mathf.Abs(playerView.GetRigidBody().velocity.y) < 0.001) playerModel.isJumping = true; else playerModel.isJumping = false;
        if (Input.GetKey(KeyCode.Space) && playerModel.isPlatformed) playerModel.isJumping = true; else playerModel.isJumping = false;

        //if (Input.GetKeyDown(KeyCode.Space)) Fire();
        if (Input.GetMouseButtonDown(0))
        {
            if (playerModel.isReloadingWeapon)
            {
                Debug.Log("Player is Reloading his Weapon :( ");
                return;
            }
            else
            {
                Fire();
            }
        }
        if (Input.GetKeyDown(KeyCode.H)) Heal();
        if (Input.GetKeyDown(KeyCode.I))
        {
            var inventoryModel = inventoryView.RetrieveInventoryController().inventoryModel;
            inventoryModel.isInventoryOpened = !inventoryModel.isInventoryOpened;
            inventoryView.RetrieveInventoryController().InventoryVisibility();
            
            //  inventoryView.gameObject.SetActive(inventoryModel.isInventoryOpened);   previous code
          //  inventoryView.RetrieveInventoryController().AddItemTotheInventory(new ItemController { itemQuantity = 1 });
          //  inventoryView.RetrieveInventoryController().AddItemTotheInventory(new ItemController { itemQuantity = 4 });
            Debug.Log("Number of items in the inventoty" + inventoryView.RetrieveInventoryController().inventoryModel.RetrieveItemControllerList().Count);
        }


    }

    public void FlipCharacter()
    {

    }
    public bool IsPlatformed()
    {
        //  playerModel.playerSize = new Vector2(1f, 0.1f);
        RaycastHit2D ray = Physics2D.BoxCast(playerView.transform.position, playerView.playerSize, 0f, Vector2.down, playerModel.platformDetLength, playerView.layerMask);
        Debug.DrawRay(playerView.transform.position, Vector2.down * playerModel.platformDetLength, Color.red);
        return ray.collider != null;

    }
    public void Fire()
    {
        Debug.Log("Player Ammo : " + playerModel.ammoStock);
        PlayerAmmoController playerAmmo = playerAmmoPool.RetrieveAmmo();
        playerAmmo.SetAmmo(playerView.ammoSpawnPoint, playerAmmoPool, playerModel.isFacingDef);
        playerModel.ammoStock--;
        if (playerModel.ammoStock < 1)
        {
            playerView.ReloadWeapon();
        }
        playerUIController.UpdateAmmoBarUIAfterFiring();
    }
    public void HandlePlayerAnimations()
    {
        if (horizontalInput != 0)
        {
            playerView.GetAnimator().SetBool("IsRunning", true);
        }
        else
        {
            playerView.GetAnimator().SetBool("IsRunning", false);
        }
        if (playerModel.isJumping)
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
    public void Heal()
    {
        playerUIController.ResetPlaytHealthBarUIAfterHealing();
    }
    public InventoryView RetrieveInventoryView()
    {
        return inventoryView;
    }
}
