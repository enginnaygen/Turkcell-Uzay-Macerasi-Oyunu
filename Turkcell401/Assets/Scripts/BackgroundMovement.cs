using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    float positionY;
    float distance = 10.24f;

    private void Start()
    {
        positionY = transform.position.y;
    }

    void Update()
    {
        if(Camera.main.transform.position.y > positionY + distance)
        {
            BackgroundShifting();
        }
    }

    void BackgroundShifting()
    {
        positionY += distance * 2;
        transform.position = new Vector2(0, positionY);


    }
}
