using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonWeapon : MonoBehaviour
{
    public GameObject fireballprefab;


    public float bulletSpawnDistance = .5f;

    public Vector3 firepoint;




    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)
            || Input.GetKeyDown(KeyCode.LeftControl)
            || Input.GetMouseButtonDown(0))
        {
            FireBullet(transform.up
                        * bulletSpawnDistance
                        + transform.position,
                        transform.rotation);
        }
    }

    private void FireBullet(Vector3 position, Quaternion rotation)
    {
        Instantiate(fireballprefab, position = firepoint, rotation);
    }
}
