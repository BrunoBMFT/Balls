using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public GameObject balls;
    private Rigidbody2D rb2d;
    public float speed;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Vector2 dir = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        rb2d.velocity = dir * speed * Time.deltaTime;
    }

 //  public void PowerUp()
 //  {
 //      Debug.Log("hi2");
 //      Destroy(gameObject);
 //      balls.transform.localScale = new Vector2(transform.localScale.x / 2, transform.localScale.y / 2);
 //  }
}
