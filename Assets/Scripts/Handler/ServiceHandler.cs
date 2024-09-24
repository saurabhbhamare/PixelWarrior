using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServiceHandler : MonoBehaviour
{
    [SerializeField] private PlayerView playerView;
    [SerializeField] private PlayerUIController playerUIController;
    
    //Services
    public static PlayerService playerService;
    private EnemyService enemyService;
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
        uiService = new UIService(playerUIController);
    }
}
