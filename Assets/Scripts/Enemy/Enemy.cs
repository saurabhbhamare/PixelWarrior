using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected int health;
    protected int strikeDamage;
    protected float moveSpeed;

    private void Start()
    {
        health = 100;
        strikeDamage = 10;
        moveSpeed = 10f;
    }
    protected void Attack()
    {

    }
    protected void TakeDamage()
    {

    }
    protected void HandleEnemyMovement()
    {

    }
  

}
