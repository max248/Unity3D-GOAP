using UnityEngine;
using System.Collections.Generic;

public class control_bot : MonoBehaviour
{
    public float speed = 10f; public float move = 0.5f; public bool facingRight; // Use this for initialization 
    private Rigidbody2D body;
    void Start()
    {
        facingRight = true;
    }
    void FixedUpdate() { }
    //столкновение со статическим объектом 
    /*void OnCollisionEnter2D(Collision2D col)
    {
        if ((col.gameObject.name == "tube") || (col.gameObject.name == "house"))
        {
            move *= -1;
        }
    }*/
    //разворот перед препеятствием 
    /*void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "moveTrigger")
        {
            print("collide"); move *= -1f;
        }
    }*/
    // Update is called once per frame 
    void Update()
    {
        body = GetComponent<Rigidbody2D>();
        body.velocity = new Vector2(move * speed, body.velocity.y);
        if (facingRight && move < 0) { flip(); }
        if (!facingRight && move > 0) { flip(); }
    }
    //отображение ткстуры 
    void flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
