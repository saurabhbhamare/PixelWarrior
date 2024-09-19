using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteScrollingBackground : MonoBehaviour
{
    public float speed = 0.1f;
    public GameObject background1;
    //public GameObject background2;
    public Vector3 posb1;
    public Vector3 posb2;

    private void Start()
    {
        
    }

    private void Update()
    {
        background1.transform.Translate(Vector2.down);
    }
}
