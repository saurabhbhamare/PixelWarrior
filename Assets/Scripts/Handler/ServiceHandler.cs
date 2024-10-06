using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServiceHandler : MonoBehaviour
{
    [SerializeField] private PlayerView playerView;
    [SerializeField] private InventoryView inventoryView;  // invenotry visual
    [SerializeField] private PlayerUIController playerUIController;
    [SerializeField] private ItemView itemView;
    
    
    
    //Services
    private PlayerService playerService;
    private EnemyService enemyService;
 //   private InventoryService inventoryService;
    private InventoryService inventoryService;


    private UIService uiService;
    public PlayerAmmoView playerAmmoView;

    private void Start()
    {
        InitializeServices();
    }
    private void InitializeServices()
    {
        playerService = new PlayerService(playerView,playerAmmoView,playerUIController,inventoryView);
        enemyService = new EnemyService(playerService);
        inventoryService = new InventoryService(inventoryView,itemView);
        uiService = new UIService(playerUIController);
    }
    private void SetDependencies()
    {
       // playerService.
    }
}
