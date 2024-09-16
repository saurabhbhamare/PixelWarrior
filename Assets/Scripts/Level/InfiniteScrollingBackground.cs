using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteScrollingBackground : MonoBehaviour
{
    public float speed = 0.1f;
    public GameObject background1;
    public GameObject background2;

    private float backWidth;

    void Start()
    {
        backWidth = background1.GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        MoveBackground(background1);
        MoveBackground(background2);

        if (background1.transform.position.x <= -backWidth)
        {
            background1.transform.position = new Vector2(background2.transform.position.x + backWidth, background1.transform.position.y);
        }

        if (background2.transform.position.x <= -backWidth)
        {
            background2.transform.position = new Vector2(background1.transform.position.x + backWidth, background2.transform.position.y);
        }
    }

    void MoveBackground(GameObject background)
    {
        background.transform.position += Vector3.down * speed * Time.deltaTime;
    }
}
