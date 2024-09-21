using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    [SerializeField] private float bulletSpeed;
    
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        transform.Translate(Vector2.right*bulletSpeed);
    }
    public void MoveTowardsTarget()
    {
        //rigidbody.velocity = transform.right * bulletSpeed;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
