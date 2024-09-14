using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUnlockPoint : MonoBehaviour
{
    [SerializeField] private GameObject levelUnlockDoorObject; 
    private void OnCollisionEnter2D(Collision2D collision)
    {
      //  Time.timeScale = 0;
        levelUnlockDoorObject.SetActive(false);

    }
}
