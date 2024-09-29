using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServiceHandler : MonoBehaviour
{
    [SerializeField] private PlayerView playerView;
    [SerializeField] private PlayerUIController playerUIController;
    
    
    //Services
    private PlayerService playerService;
    private EnemyService enemyService;
 //   private InventoryService inventoryService;
    [SerializeField] private InventoryService inventoryService;


    private UIService uiService;
    public PlayerAmmoView playerAmmoView;

    private void Start()
    {
        InitializeServices();
    }
    private void InitializeServices()
    {
        playerService = new PlayerService(playerView,playerAmmoView);
        enemyService = new EnemyService(playerService);
      //  inventoryService = new InventoryService();
        uiService = new UIService(playerUIController);

    }
}
