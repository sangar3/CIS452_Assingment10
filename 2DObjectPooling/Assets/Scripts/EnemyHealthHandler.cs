using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemyHealthHandler : MonoBehaviour
{
    public int health = 3;
    public GameObject enemy;

    public GameObject level2;



    

    void Update()
    {
        if( health == 0)
        {
            Level1EnemyDead();

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

    public void Level1EnemyDead()
    {
        Debug.Log(" Enemy 1 dead");
        Destroy(enemy);
        level2.SetActive(true);

    }


}
