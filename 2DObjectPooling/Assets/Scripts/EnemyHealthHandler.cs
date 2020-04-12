using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemyHealthHandler : MonoBehaviour
{
    public int health = 3;
    public GameObject enemy;
    public AudioClip hurtfx;
    public GameObject level1text;
    public GameObject level2;
    public GameObject level2text;





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
            AudioManager.Instance.PlaySFX(hurtfx, 3.0f);

        }
    }

    public void Level1EnemyDead()
    {
        Debug.Log(" Enemy 1 dead");
        Destroy(enemy);
        level1text.SetActive(false);
        level2.SetActive(true);
        level2text.SetActive(true);

    }


}
