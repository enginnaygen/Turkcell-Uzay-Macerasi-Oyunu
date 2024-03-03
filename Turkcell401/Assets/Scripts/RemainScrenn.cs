using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemainScrenn : MonoBehaviour
{
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x> ScreenCalculate.instance.Witdh)
        {
            Vector2 temp;
            temp = transform.position;
            temp.x = ScreenCalculate.instance.Witdh;
            transform.position = temp;
        }
        if(transform.position.x < -ScreenCalculate.instance.Witdh)
        {
            Vector2 temp;
            temp = transform.position;
            temp.x = -ScreenCalculate.instance.Witdh;
            transform.position = temp;
        }
    }
}
