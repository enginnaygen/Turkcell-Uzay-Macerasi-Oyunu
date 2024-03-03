using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathControl : MonoBehaviour
{
    [SerializeField] GameObject panel;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            FindObjectOfType<Score>().EndGameTexts();
            PanelOpen();
            Destroy(collision.gameObject);


        }
    }

    public void PanelOpen()
    {
        panel.SetActive(true);

    }
}
