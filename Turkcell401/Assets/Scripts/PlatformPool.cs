using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPool : MonoBehaviour
{
    [SerializeField] int maxPlatform;
    [SerializeField] GameObject platformPrefab, deathplatformPrefab;
    [SerializeField] GameObject playerPrefab;
    [SerializeField] float distanceBetweenPlatforms = 3f;

    Vector2 platformPosition;
    Vector2 playerPosition;
    List<GameObject> platforms = new List<GameObject>();

    private void Start()
    {
        InstantiatePlatforms();
    }

    private void Update()
    {
        if (platforms[platforms.Count-1].transform.position.y < 
            Camera.main.transform.position.y 
            + ScreenCalculate.instance.Height)//kameranin en ust noktasi son platformu gecince calisacak
        {
            PositionPlatform();
        }
    }
    void InstantiatePlatforms()
    {
        platformPosition = new Vector2(0, 0);
        playerPosition = new Vector2(0, 0.5f);

        GameObject player = Instantiate(playerPrefab, playerPosition, Quaternion.identity);
        GameObject firstPlatform = Instantiate(platformPrefab, playerPosition, Quaternion.identity);
        platforms.Add(firstPlatform);
        firstPlatform.GetComponent<Platform>().PlatformMove = false;
        
        NextPlatformPosition();

        for (int i = 0; i < maxPlatform; i++)
        {
            GameObject platform = Instantiate(platformPrefab, platformPosition, Quaternion.identity);
            platforms.Add(platform);
            if(i % 2==0)
            {
                platform.GetComponent<GoldArrange>().ActiveGold();
            }
            NextPlatformPosition();
        }

        GameObject diePlatform = Instantiate(deathplatformPrefab, platformPosition, Quaternion.identity);
        platforms.Add(diePlatform);
        NextPlatformPosition();
    }

    void NextPlatformPosition()
    {
        platformPosition += new Vector2(Mathf.Clamp(Random.Range(-1f,1f),-1.75f,1.75f), distanceBetweenPlatforms);
    }

    void PositionPlatform()
    {
        for (int i = 0; i < 5; i++) //10  obje gecildiginde bastaki 5 obje alinip son 5 objenin sonuna ekleniyor
        {
            GameObject temp;
            temp = platforms[i + 5];  //
            platforms[i + 5] = platforms[i]; //en bastaki platformu 5 birim oteliyoruz
            platforms[i] = temp;
            platforms[i + 5].transform.position = platformPosition;
            if(platforms[i + 5].gameObject.tag == "Platform") //burasi her yukarri dogru platformlar yenilendiginde
                                                              //rastgele altýn olusturuolmasini sagliyor
            {
                platforms[i + 5].GetComponent<GoldArrange>().DeactiveGold();

                float randomGold = Random.Range(0f, 1f);
                if(randomGold>0.5f)
                {
                    platforms[i + 5].GetComponent<GoldArrange>().ActiveGold();
                }
            }
            NextPlatformPosition();
        }
    }
}
