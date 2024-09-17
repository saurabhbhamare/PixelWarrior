using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoBoard : MonoBehaviour
{
    public GameObject hintUI;
    public string hintMessage;
    void Start()
    {
        hintUI.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<PlayerView>())
        {
            hintUI.gameObject.SetActive(true);
        }
        Debug.Log("collsion for infoboard happened");

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<PlayerView>())
        {
            hintUI.SetActive(false);
        }
    }
}
