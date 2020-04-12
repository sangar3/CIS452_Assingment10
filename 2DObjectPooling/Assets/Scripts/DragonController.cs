using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonController : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public  Rigidbody2D player;

    void FixedUpdate()
    {
        MovePlayer();
    }
   

    void MovePlayer()
    {
        player.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * moveSpeed * Time.deltaTime; 
    }
}
