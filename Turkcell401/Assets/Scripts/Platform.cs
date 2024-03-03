using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    //float direction = 1;
    //[SerializeField] float platformSpeed;
    float randomSpeed, minSize, maxSize;

    BoxCollider2D boxCollider;

    public bool PlatformMove { get; set; } = true;


    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();

    }

    private void Start()
    {
        //randomSpeed = Random.Range(0.5f, 1f);
        if (DataContain.ReadValueEasy() == 1)
        {
            randomSpeed = Random.Range(0.5f, 1f);

        }
        else if (DataContain.ReadValueNormal() == 1)
        {
            randomSpeed = Random.Range(1f, 1.5f);

        }
        else if (DataContain.ReadValueHard() == 1)
        {
            randomSpeed = Random.Range(1.5f, 2f);

        }


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
        if(PlatformMove)
        {
            float horizontalMove = Mathf.PingPong(Time.time * randomSpeed, maxSize - minSize) + minSize;
            Vector2 pingPongX = new Vector2(horizontalMove, transform.position.y);
            transform.position = pingPongX;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Foots")
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            player.transform.parent = transform;
            
            player.GetComponent<PlayerMovement>().JumpNumber = 0;
            FindObjectOfType<SliderControl>().SliderValue(FindObjectOfType<PlayerMovement>().JumpRight, FindObjectOfType<PlayerMovement>().JumpNumber);



        }
    }

    /*private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Foots")
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");

            


        }
    }*/
    /*private void FixedUpdate()
    {
        
        if (transform.position.x > 1.75f)
        {
            direction *= -1;
        }
        if (transform.position.x < -1.75f)
        {
            direction *= -1;

        }
        transform.Translate(new Vector2(direction * platformSpeed, 0));
    }*/
}
