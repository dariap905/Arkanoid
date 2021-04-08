using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        CounterScript.counter += 1;
        Destroy(gameObject);
    }
}
