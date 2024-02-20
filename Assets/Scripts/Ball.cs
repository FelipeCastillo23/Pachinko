using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using Unity.VisualScripting;
using UnityEngine;

//This is a test comment

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    private float horizontal;
    private Vector2 startPos;
    private bool gameStart = false;
    private Rigidbody2D rb;

    private void Start()
    {
        startPos = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    private void Update()
    {
        if (!gameStart)
        {
            horizontal = Input.GetAxisRaw("Horizontal");
            rb.velocity = new Vector2(horizontal * speed, 0);
        }

        if (Input.GetButtonDown("Jump") && !gameStart)
        {
            gameStart = true;
            rb.gravityScale = 1f;
        }

        if (Input.GetButtonDown("Cancel") && gameStart)
        {
            Respawn();
        }

        if (transform.position.y < -5f)
        {
            Respawn();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Collision");
        if (other.gameObject.CompareTag("GreenBox"))
        {
            //Debug.Log("GreenBox");
        }
        if (other.gameObject.CompareTag("YellowBox"))
        {
            //Debug.Log("YellowBox");
        }
    }

    private void Respawn()
    {
        transform.position = startPos;
        gameStart = false;
        rb.gravityScale = 0f;
    }
}
