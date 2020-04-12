using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonWeapon : MonoBehaviour
{


    public float fireDelay = 0.25f;
    private float cooldownTimer = 0;


    ObjectPooler objectPooler;

    
    public Vector3 fireballOffset = new Vector3(0, 0.0f, 0);
   

    private void Start()
    {
        objectPooler = ObjectPooler.instance;
     

    }


    void FixedUpdate()
    {
        shoot();
    }

   public void shoot()
    {
        cooldownTimer -= Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && cooldownTimer <= 0)
        {
            cooldownTimer = fireDelay;
            Vector3 offset = transform.rotation * fireballOffset;
            objectPooler.SpawnFromPool("Fireball", transform.position + offset, Quaternion.identity); //shoot fireball

             
        }
    }
}


