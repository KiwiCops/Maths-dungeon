using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public float moveBy;
    public float Sprintspeed;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        sprint();
    }

    void Move()
    //Move left or right
    {
        float x = Input.GetAxisRaw("Horizontal");
        float moveBy = x * speed;
        rb.velocity = new Vector2(moveBy, rb.velocity.y);
    }
    void sprint()
    {
        if (Input.GetKey(KeyCode.X))
        {
            rb.velocity = new Vector2(moveBy * 2, rb.velocity.y);
        }

    }
}
