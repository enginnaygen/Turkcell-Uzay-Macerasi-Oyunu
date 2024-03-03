using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreControl : MonoBehaviour
{
    [SerializeField] Text easyScore, normalScore, hardScore, easyGold, normalGold, hardGold;
    private void Start()
    {
        easyScore.text = "Score: " + DataContain.ReadValueEasyScore();
        easyGold.text = "x" + DataContain.ReadValueEasyGold();

        normalScore.text = "Score: " + DataContain.ReadValueNormalScore();
        normalGold.text = "x" + DataContain.ReadValueNormalGold();

        hardScore.text = "Score: " + DataContain.ReadValueHardScore();
        hardGold.text = "x" + DataContain.ReadValueHardGold();



    }


    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
