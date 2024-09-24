using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float speed = 1f;
    private Vector2 startPosition;
    private float newPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        newPosition = Mathf.Repeat(Time.time * speed, GetComponent<SpriteRenderer>().bounds.size.x);
        transform.position = startPosition + Vector2.down * newPosition;
    }
}
