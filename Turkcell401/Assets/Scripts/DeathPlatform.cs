using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlatform : MonoBehaviour
{
    float randomSpeed, minSize, maxSize;

    BoxCollider2D boxCollider;

    public bool PlatformMove { get; set; } = true;

    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();

    }

    private void Start()
    {
        randomSpeed = Random.Range(0.5f, 1f);


        float objectWidth = boxCollider.bounds.size.x / 2;

        if (transform.position.x > 0)
        {
            minSize = objectWidth;
            maxSize = ScreenCalculate.instance.Witdh - objectWidth; //objenin transform degeri tam orta noktasi oldugu
                                                                    //objenin sahip oldugu genisligin yarisini
                                                                    //cikariyoruz
        }
        else
        {
            minSize = -ScreenCalculate.instance.Witdh + objectWidth;
            maxSize = -objectWidth;
        }
    }

    private void Update()
    {
        if (PlatformMove)
        {
            float horizontalMove = Mathf.PingPong(Time.time * randomSpeed, maxSize - minSize) + minSize;
            Vector2 pingPongX = new Vector2(horizontalMove, transform.position.y);
            transform.position = pingPongX;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            FindObjectOfType<Score>().EndGameTexts();
            FindObjectOfType<DeathControl>().PanelOpen();
            Destroy(collision.gameObject);


        }
    }
   
}
