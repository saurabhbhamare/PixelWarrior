using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoBoard : MonoBehaviour
{
    public GameObject hintUI;
    void Start()
    {
        hintUI.SetActive(false);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        hintUI.gameObject.SetActive(true);
    }
}
