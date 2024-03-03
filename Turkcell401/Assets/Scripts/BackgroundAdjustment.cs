using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAdjustment : MonoBehaviour
{
    SpriteRenderer sprite;

    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();    
    }
    void Start()
    {
        Vector2 scale = transform.localScale;
        float spriteWidth = sprite.size.x;
        float screenHeight = Camera.main.orthographicSize * 2;
        float screenWidth =  screenHeight / Screen.height * Screen.width; //Camera.main.aspect * screenHeight;
        scale.x = screenWidth / spriteWidth;
        
        //Vector2 scale = new Vector2(screenWidth,screenHeight);

        transform.localScale = scale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
