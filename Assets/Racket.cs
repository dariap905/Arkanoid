using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour {
    public float speed = 150.0f;

    //utilizamos fixedupdate cuando trabajamos en fisica
    void FixedUpdate()
    {
        float horizontalDirection = Input.GetAxisRaw("Horizontal");

        GetComponent<Rigidbody2D>().velocity = Vector2.right * horizontalDirection * speed;
    }
}
