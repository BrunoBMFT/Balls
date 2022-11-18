using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Red : Green
{
    private Player player;
    private Rigidbody2D rb2d;
    private bool isSpecial = false;
    private float timer;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Vector2 dir = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        rb2d.velocity = dir * speed * Time.deltaTime;
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
   //     timer += Time.deltaTime;
   //     if (timer > 10)
   //         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   //     if (timer > 15)
   //         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void NewBall()
    {
        Vector3 position = new Vector3(Random.Range(-10, 10), Random.Range(-3, 4), 1);
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall" && isSpecial)
        {
            Vector2 dir = player.transform.position - transform.position;
            rb2d.velocity = dir * (speed / 12) * Time.deltaTime;
        }
    }
    
}

