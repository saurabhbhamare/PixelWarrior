using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServiceHandler : MonoBehaviour
{
    [SerializeField] private PlayerView playerView;
    //Services
    private PlayerService playerService;
    //private EnemyService enemyService;

    private void Start()
    {
        InitializeServices();
    }
    private void InitializeServices()
    {
        playerService = new PlayerService(playerView);
        //enemyService = new EnemyService();
    }
}
