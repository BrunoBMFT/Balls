using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green : MonoBehaviour
{
    public Red red;
    private Rigidbody2D rb2d;
    public float speed;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Vector2 dir = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        rb2d.velocity = dir * speed * Time.deltaTime;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ScoreManager.instance.AddPoint();
            NewPosition();
            red.NewBall();
        }
    }
    private void NewPosition()
    {
        rb2d.position = new Vector2(Random.Range(-11, 11), Random.Range(-4, 4));
        Vector2 dir = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        rb2d.velocity = dir * speed * Time.deltaTime;
    }
}
