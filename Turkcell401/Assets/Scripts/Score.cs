using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text score, goldText;
    [SerializeField] Text scoreEnd, goldTextEnd;

    public int IncreaseGold { get; set; }
    public int Scoree { get; set; }
    public int HighScore { get; set; }
    public int HighestGold { get; set; }

    bool gameContinue = true;


    void Start()
    {
        score.text = "Score: " + 0;
        goldText.text = "x" + 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameContinue)
        {
            Scoree = (int)Camera.main.transform.position.y;
            score.text = "Score: " + Scoree;
            goldText.text = IncreaseGold.ToString();
        }
       
    }

    public void EndGameTexts()
    {
        if(DataContain.ReadValueEasy()==1) //oyun kolay mi?
        {
            HighScore = DataContain.ReadValueEasyScore();
            HighestGold = DataContain.ReadValueEasyGold();

            if(Scoree>HighScore)
            {
                DataContain.ArrangeEasyScore(Scoree);
            }
            if (IncreaseGold > HighestGold)
            {
                DataContain.ArrangeEasyGold(IncreaseGold);
            }
        }
        else if (DataContain.ReadValueNormal() == 1) //oyun normal mi?
        {
            HighScore = DataContain.ReadValueNormalScore();
            HighestGold = DataContain.ReadValueNormalGold();

            if (Scoree > HighScore)
            {
                DataContain.ArrangeNormalScore(Scoree);
            }
            if(IncreaseGold>HighestGold)
            {
                DataContain.ArrangeNormalGold(IncreaseGold);
            }
        }
        else if (DataContain.ReadValueHard() == 1) //oyun normal mi?
        {
            HighScore = DataContain.ReadValueHardScore();
            HighestGold = DataContain.ReadValueHardGold();

            if (Scoree > HighScore)
            {
                DataContain.ArrangeHardScore(Scoree);
            }
            if (IncreaseGold > HighestGold)
            {
                DataContain.ArrangeHardGold(IncreaseGold);
            }
        }
        gameContinue = false;
        scoreEnd.text = "Score: " + Scoree;
        goldTextEnd.text = "x" + IncreaseGold;

    }
}
