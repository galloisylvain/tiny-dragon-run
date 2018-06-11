using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoves : MonoBehaviour {

    public float thrust;
    public Rigidbody2D rb;
    float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = 10.0f;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            rb.velocity = Vector2.up * thrust;
        }
    }
}
