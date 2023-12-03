using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float Speed;

    void Update()
    {
        transform.position = new Vector3(transform.position.x - Speed, transform.position.y - Speed, -4);

        if (transform.position.x < -500 )
        {
            this.enabled = false;
        }
    }
}
