﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iceball : MonoBehaviour
{
    public Rigidbody2D projectile;
    public float moveSpeed = 10.0f;

  

    // Update is called once per frame
    void Update()
    {
        projectile.velocity = new Vector2(0 , -1) * moveSpeed;

    }
}
