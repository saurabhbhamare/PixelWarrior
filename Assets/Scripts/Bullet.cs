using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    [SerializeField] private float bulletSpeed=10f;
    private bool moveLeft;
    private bool moveRight;
    
    
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        //if(moveLeft)
        // {
        //     Debug.Log("running moveLeft");
        //     transform.Translate(Vector2.left * bulletSpeed * Time.deltaTime);
        // }
        //else if(moveRight)
        // {
        //     transform.Translate(Vector2.right * bulletSpeed * Time.deltaTime);
        // }
        transform.Translate(Vector2.right * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
    //public void ConfigureBullet(bool moveRight, bool moveLeft)
    //{
    //    this.moveRight = moveRight;
    //    this.moveLeft = moveLeft; 
    //}
}
