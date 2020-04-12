using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{


    public GameObject projectile;
    public float nextFire = 1.0f;
    public float currentTime = 0.0f;




 


    public Vector3 fireballOffset = new Vector3(0, 0.0f, 0);


  


    void FixedUpdate()
    {
        enemyshoot();
    }

    public void enemyshoot()
    {
        currentTime += Time.deltaTime;
        if(currentTime > nextFire)
        {
            nextFire += currentTime;
            Vector3 offset = transform.rotation * fireballOffset;
            Instantiate(projectile, transform.position + offset, Quaternion.identity); //spawn iceball
            nextFire -= currentTime;

            currentTime = 0.0f;

        }
    }
}
