using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyHealthHandler : MonoBehaviour
{
    public int health = 3;
    public GameObject enemy;




    

    void Update()
    {
        if( health == 0)
        {
            EnemyDead();

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

    public void EnemyDead()
    {
        Debug.Log(" dead");
        Destroy(enemy);
    }


}
