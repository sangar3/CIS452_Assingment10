using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballBehavior : MonoBehaviour
{
    

    public float unitsPerSecond = 1;

    public float lifetime = 4;

    

    

    private void Start()
    {
        Invoke("Destroy", lifetime);
    }

    private void Update()
    {
        var forwardDir = transform.InverseTransformDirection(transform.up);
        transform.Translate(forwardDir * unitsPerSecond * Time.deltaTime);
    }

   

    private void Destroy()
    {
        gameObject.SetActive(false);
    }
}
