using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenCalculate : MonoBehaviour
{
    public static ScreenCalculate instance;

    public float Witdh { get; private set; }
    public float Height { get; private set; }
    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }

        Height = Camera.main.orthographicSize;
        Witdh = Height * Camera.main.aspect;
    }
}
