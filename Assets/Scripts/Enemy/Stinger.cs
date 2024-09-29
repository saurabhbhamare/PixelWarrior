using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stinger : MonoBehaviour
{
    public GameObject bullet;
    public float spawnInterval;
   // public PlayerService playerService;
    private void Start() 
    {
        StartCoroutine(Attack());
    }
    IEnumerator Attack()
    {
        while(true)
        {
            Instantiate(bullet, transform.position,transform.rotation);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
    
}
