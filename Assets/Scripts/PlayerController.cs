using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public float posX;
    public Rigidbody2D rb2D;


    void Update()
    {
        Move();
        Jump();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Limit"))
        {
            Destroy(gameObject);
        }
    }

    void Move()
    {
        posX = Input.GetAxis("Horizontal");
        transform.position += (Vector3) new Vector2(posX * speed * Time.deltaTime, 0f);
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2D.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
