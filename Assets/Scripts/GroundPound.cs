using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPound : MonoBehaviour
{

    public Rigidbody2D rb;
    public Rigidbody2D box;
    public Rigidbody2D box2;
    public float speed = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, rb.velocity.y);
        //move section taught to me by Ryan Barthelet
        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(new Vector2(0, 400));
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") && gameObject.transform.position.y > collision.gameObject.transform.position.y)
        {
            box.AddForce(new Vector2(0, 200));
            box2.AddForce(new Vector2(0, 200));

            //add whatever you want to happen when you groundpound here
        }
    }
}
