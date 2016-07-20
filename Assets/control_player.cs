using UnityEngine;
using System.Collections.Generic;

[RequireComponent(typeof(Rigidbody2D))]

public class control_player : MonoBehaviour
{

    public float speed = 0.5f;
    public float acceleration = 0;
    public int score;

    private Vector3 direction;
    private Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        body.gravityScale = 0;
    }

    void FixedUpdate()
    {
        body.AddForce(direction * body.mass * speed * acceleration);

        if (Mathf.Abs(body.velocity.x) > speed)
        {
            body.velocity = new Vector2(Mathf.Sign(body.velocity.x) * speed, body.velocity.y);
        }

        if (Mathf.Abs(body.velocity.y) > speed)
        {
            body.velocity = new Vector2(body.velocity.x, Mathf.Sign(body.velocity.y) * speed);
        }
    }   

    void Update()
    {
        direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
      //  OnTriggerEnter2D(Collider2D col);


    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "star") {
            Destroy(col.gameObject);
            score++;
        }
    }
}