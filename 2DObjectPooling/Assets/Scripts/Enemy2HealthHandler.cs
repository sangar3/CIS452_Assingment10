using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2HealthHandler : MonoBehaviour
{
    public int health = 3;
    public GameObject enemy;

    





    void Update()
    {
        if (health == 0)
        {
            Level2EnemyDead();

        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "FireBall")
        {
            Debug.Log(" enemyhit by fireball");
            --health;

        }
    }

    public void Level2EnemyDead()
    {
        Debug.Log(" Enemy 2 dead");
        Destroy(enemy);
        

    }
}
