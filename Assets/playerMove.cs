using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{

    public Rigidbody2D rb;
    public int speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector2(0, 1) * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector2(0, -1) * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector2(1, 0) * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector2(-1, 0) * speed);
        }

    }
}
