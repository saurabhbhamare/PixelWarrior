using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    [SerializeField] private GameObject levelCompletionPanel;
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.GetComponentInParent<PlayerView>())
        {
            Debug.Log("collision happened");
            levelCompletionPanel.SetActive(true);
        }
    }
}
