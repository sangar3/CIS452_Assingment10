using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BossHealthHandler : MonoBehaviour
{
    public int health = 3;
    public GameObject enemy;







    void Update()
    {
        if (health == 0)
        {
            BossDead();

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

    public void BossDead()
    {
        
        enemy.SetActive(false);
        SceneManager.LoadScene("YouWin");

    }
}
