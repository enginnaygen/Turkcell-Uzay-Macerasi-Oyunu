using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] Sprite[] musicsSprite;
    [SerializeField] Button musicButton;


    private void Start()
    {
        MusicPlayerPrefs();

        if(DataContain.IsMusicOpen()== false)
        {
            DataContain.ArrangeMusic(1);
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void GetArrange()
    {
        SceneManager.LoadScene("Arrange");
    }
    public void HighScoreScene()
    {
        SceneManager.LoadScene("HighScore");
    }

    public void MusicArrange()
    {
        if(DataContain.ReadValueMusic()==1)
        {
            DataContain.ArrangeMusic(0);
            musicButton.image.sprite = musicsSprite[1];
        }
        else
        {
            DataContain.ArrangeMusic(1);
            musicButton.image.sprite = musicsSprite[0];
        }
    }

    public void MusicPlayerPrefs()
    {
        if(DataContain.ReadValueMusic() == 1)
        {
            musicButton.image.sprite = musicsSprite[0];

        }
        else
        {
            musicButton.image.sprite = musicsSprite[1];

        }
    }


}
