using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D enemy;

    public float moveSpeed = 15f;

    public bool  changedDirection = false;

   
    void Start()
    {
        enemy = this.gameObject.GetComponent<Rigidbody2D>();
        Debug.Log("enemy start");
    }
    
    void Update()
    {
        moveEnemy();
    }


    public void moveEnemy()
    {
        if( changedDirection == true )
        {
            enemy.velocity = new Vector2(1, 0) * -1 * moveSpeed ;
        }
        else if ( changedDirection == false)
        {

            enemy.velocity = new Vector2(1, 0) * moveSpeed ;
            //Debug.Log("direction is false");
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if( col.gameObject.tag == "RightWall")
        {
            Debug.Log("hit right wall");
            changedDirection = true;
        }
        if (col.gameObject.tag == "LeftWall")
        {
            Debug.Log("hit left wall");
            changedDirection = false;
        }
    }


   
}
