using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [SerializeField] GameObject panel;

    [SerializeField] Button easy, normal, hard;

    private void Start()
    {
        if(DataContain.ReadValueEasy() == 1)
        {
            easy.interactable = false;
            normal.interactable = true;
            hard.interactable = true;
        }
        else if (DataContain.ReadValueNormal() == 1)
        {
            easy.interactable = true;
            normal.interactable = false;
            hard.interactable = true;
        }
        else if(DataContain.ReadValueHard() == 1)
        {
            easy.interactable = true;
            normal.interactable = true;
            hard.interactable = false;
        }
        else
        {
            easy.interactable = false;
            normal.interactable = true;
            hard.interactable = true;
        }
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
        panel.SetActive(false);
    }

    public void ButtonSelected(string hardness)
    {
        switch (hardness)
        {
            case "easy":
                DataContain.ArrangeEasy(1);
                DataContain.ArrangeNormal(0);
                DataContain.ArrangeHard(0);
                easy.interactable = false;
                normal.interactable = true;
                hard.interactable = true;
                break;

            case "normal":
                DataContain.ArrangeEasy(0);
                DataContain.ArrangeNormal(1);
                DataContain.ArrangeHard(0);
                easy.interactable = true;
                normal.interactable = false;
                hard.interactable = true;
                break;

            case "hard":
                DataContain.ArrangeEasy(0);
                DataContain.ArrangeNormal(0);
                DataContain.ArrangeHard(1);
                easy.interactable = true;
                normal.interactable = true;
                hard.interactable = false;
                break;

            default:
                break;
        }
    }
}
