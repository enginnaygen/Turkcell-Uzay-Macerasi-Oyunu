using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    float speed = 1;
    float maxSpeed = 2;
    float acceleration = 0.05f;

    private void Start()
    {
        if(DataContain.ReadValueEasy()==1)
        {
            speed = 0.5f;
            maxSpeed = 3f;
            acceleration = 0.05f;
        }
        else if(DataContain.ReadValueNormal() == 1)
        {
            speed = 0.8f;
            maxSpeed = 4f;
            acceleration = 0.08f;
        }
        else if (DataContain.ReadValueHard() == 1)
        {
            speed = 1f;
            maxSpeed = 5f;
            acceleration = 0.1f;
        }
    }
    void Update()
    {
        if(speed <= maxSpeed)
        {
            speed += acceleration * Time.deltaTime;
        }
        transform.position += new Vector3(0, Time.deltaTime * speed);
        
    }
}
