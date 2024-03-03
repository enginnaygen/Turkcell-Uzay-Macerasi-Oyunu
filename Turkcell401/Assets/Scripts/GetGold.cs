using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetGold : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GetComponentInParent<GoldArrange>().DeactiveGold();
            FindObjectOfType<Score>().IncreaseGold++;
        }
    }
}
