using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 10f;
    public Vector2 moveDir = Vector2.zero;
    public bool isGrounded = false;
    Vector2 spawnPoint;
    [SerializeField] private GameObject throwable;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) )
        {
            moveDir.x = -1;
        }
        if (Input.GetKeyDown(KeyCode.D)) 
        {
            moveDir.x = 1;
        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D)) 
        {
            moveDir.x = 0;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isGrounded = false;
            rb.AddForce(Vector2.up *  speed * 10);
        }

        if(transform.position.y < -5f)
        {
            Die();
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            Throw();
        }

    }

    private void FixedUpdate()
    {
        if(moveDir.x != 0)
        {
            rb.AddForce ( moveDir * speed);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Ground")
        {
            isGrounded = true;
        }
        if(collision.collider.tag == "Enemy")
        {
            Die();
        }
        if(collision.collider.tag == "Win")
        {
            Win();
        }
    }

    public void Throw()
    {
      GameObject throwing = Instantiate(throwable, transform.position + Vector3.right, transform.rotation);
    throwing.GetComponent<Rigidbody2D>().velocity = Vector3.right * speed*2;
    }
    private void Die()
    {
        transform.position = spawnPoint;
    }

    private void Win()
    {
        Debug.Log("win");
    }
}
