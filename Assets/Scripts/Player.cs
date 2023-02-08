using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //variables
    public float MoveSpeed;
    public Rigidbody2D body;
    float horizontal;
    Vector2 velocity;

    void Start()
    {
        
    }

    void Update()
    {
        //get vertical input from player
        horizontal = Input.GetAxisRaw("Horizontal");
        //calculate the velocity
        velocity.x = MoveSpeed * horizontal;
        //update the rigid body velocity
        body.velocity = velocity;
    }
}
