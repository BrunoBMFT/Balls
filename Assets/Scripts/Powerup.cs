using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    private Player player;
    private Red red;
    delegate void Power();
    Power power;

    private Rigidbody2D rb2d;
    private float speed = 200;
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
            Destroy(gameObject);
            power += PowerUp;
            if (power != null)
                power();
        }
    }
    public void PowerUp()
    {
        Debug.Log("hi");
        red.transform.localScale = new Vector2(transform.localScale.x / 2, transform.localScale.y / 2);
    }
}
