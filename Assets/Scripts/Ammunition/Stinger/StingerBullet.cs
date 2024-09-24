using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StingerBullet : MonoBehaviour
{
    // Start is called before the first frame update
    private float moveSpeed;
    public PlayerService playerService;
    void Start()
    {
        moveSpeed = 0.6f;
    }
    private void Update()
    {
        this.gameObject.transform.Translate(Vector2.down * moveSpeed*Time.deltaTime) ;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(this.gameObject);
    }

}
