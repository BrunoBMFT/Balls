using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    EventManager EventManager;
    private Rigidbody2D rb2d;
    private Animator animator;
    private float moveHorizontal;
    private float moveVertical;
    public float speed;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        rb2d.velocity = new Vector2(moveHorizontal * speed * Time.deltaTime, moveVertical * speed * Time.deltaTime);
        //   float angle = Mathf.Atan2(moveHorizontal, moveVertical) * Mathf.Rad2Deg;
        //   rb2d.rotation = angle;
        //   animator.SetTrigger("Moving");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Red")
            Destroy(gameObject);
        if (collision.gameObject.tag == "Powerup")
        {
            Debug.Log("hi");
            EventManager.PowerupTouch();
        }
    }

}
