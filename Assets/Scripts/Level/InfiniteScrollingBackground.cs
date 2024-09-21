using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteScrollingBackground : MonoBehaviour
{
    public float speed = 0.1f;
    public GameObject background1;
    public GameObject background2;

    private float backgroundHeight;

    void Start()
    {
        backgroundHeight = background1.GetComponent<SpriteRenderer>().bounds.size.y;
    }

    void Update()
    {
        MoveBackground(background1);
        MoveBackground(background2);
         

        if (background1.transform.position.y <= -backgroundHeight)
        {
            background1.transform.position = new Vector2(background1.transform.position.x, background2.transform.position.y + backgroundHeight);
        }

        if (background2.transform.position.y <= -backgroundHeight)
        {
            background2.transform.position = new Vector2(background2.transform.position.x, background1.transform.position.y + backgroundHeight);
        }
    }

    void MoveBackground(GameObject background)
    {
        background.transform.position += Vector3.down * speed * Time.deltaTime;
    }
}
