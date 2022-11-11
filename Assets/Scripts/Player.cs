using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float moveHorizontal;
    private float moveVertical;
    public float speed;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        rb2d.velocity = new Vector2(moveHorizontal * speed * Time.deltaTime, moveVertical * speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Red")
            Destroy(gameObject);
    }
}
