using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red : Green
{
    private Player player;
    private Rigidbody2D rb2d;
    private bool isSpecial = false;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Vector2 dir = new Vector2(Random.Range(-1, 1), Random.Range(-1, 1));
        rb2d.velocity = dir * speed * Time.deltaTime;
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
    }

    public void NewBall()
    {
        Vector3 position = new Vector3(Random.Range(-10, 10), 1, Random.Range(-10, 10));
       GameObject obj = Instantiate(gameObject, position, Quaternion.identity);

        Red newRed = obj.GetComponent<Red>();

        float ballType = Random.Range(0, 2);
        if (ballType == 0)
            newRed.isSpecial = false;
        if (ballType == 1)
        {
            newRed.isSpecial = true;
            obj.GetComponent<Renderer>().material.color = new Color(54, 204, 102);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Wall" && isSpecial)
        {
            Debug.Log("aim");
            Vector2 dir = player.transform.position - transform.position;
            rb2d.velocity = dir * (speed/12) * Time.deltaTime;
        }
    }
}

