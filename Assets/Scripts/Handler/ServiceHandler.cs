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
    private UIService uiService;
    public Bullet bullet;

    private void Start()
    {
        InitializeServices();
    }
    private void InitializeServices()
    {
        playerService = new PlayerService(playerView,bullet);
        enemyService = new EnemyService(playerService);
        uiService = new UIService(playerUIController);
    }
}
