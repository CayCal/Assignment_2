using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float MoveSpeed;
    [SerializeField] private Rigidbody2D RB;
    private Vector2 movement;
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");              
    }

    private void FixedUpdate()
    {
        RB.velocity = movement.normalized * MoveSpeed;
    }
}
