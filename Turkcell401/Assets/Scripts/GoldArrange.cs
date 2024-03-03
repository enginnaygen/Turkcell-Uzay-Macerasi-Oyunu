using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldArrange : MonoBehaviour
{
    [SerializeField] GameObject gold;
    public void ActiveGold()
    {
        gold.SetActive(true);
    }

    public void DeactiveGold()
    {
        gold.SetActive(false);
    }
}
