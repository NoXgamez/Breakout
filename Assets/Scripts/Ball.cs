using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D body;
    Vector2 direction;

    public GameManager manager;

    private void Start()
    {
        ResetPosition();
        SetDirection();
    }

    void ResetPosition()
    {
        //reset to 0,0
        transform.position = Vector2.zero;
        //set velocity to 0
        body.velocity = Vector2.zero;
    }

    void SetDirection()
    {
        direction.x = Random.Range(20, 160);
        direction.y = Random.Range(20, 160);
        direction.Normalize();
        body.velocity = direction * moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("KillBox"))
        {
            ResetPosition();
            SetDirection();
            manager.OnLivesLost();
        }
        else if(collision.gameObject.CompareTag("Block"))
        {
            Destroy(collision.gameObject);
            manager.OnBlockDestroyed();
        }
    }
}
