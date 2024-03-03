using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//cok fazla kopyala yapistir kod oldu bu script icime sinmedi
public static class DataContain
{
    public static string easy = "easy";
    public static string normal = "normal";
    public static string hard = "hard";

    public static string easyGold = "easyGold";
    public static string normalGold = "normalGold";
    public static string hardGold = "hardGold";

    public static string easyScore = "easyScore";
    public static string normalScore = "normalScore";
    public static string hardScore = "hardScore";

    public static string music = "music";




    //1 ise secili 0 ise secili degil, zorluk ayari yapma yeri
    public static void ArrangeEasy(int easy)
    {
        PlayerPrefs.SetInt(DataContain.easy, easy);
    }
    public static int ReadValueEasy()
    {
        return PlayerPrefs.GetInt(DataContain.easy);
    }

    public static void ArrangeNormal(int normal)
    {
        PlayerPrefs.SetInt(DataContain.normal, normal);
    }
    public static int ReadValueNormal()
    {
        return PlayerPrefs.GetInt(DataContain.normal);
    }

    public static void ArrangeHard(int hard)
    {
        PlayerPrefs.SetInt(DataContain.hard, hard);
    }
    public static int ReadValueHard()
    {
        return PlayerPrefs.GetInt(DataContain.hard);
    }



    //seviyeler icin Score kaydetme yeri

    public static void ArrangeEasyScore(int easyScore) 
    {
        PlayerPrefs.SetInt(DataContain.easyScore, easyScore);
    }
    public static int ReadValueEasyScore()
    {
        return PlayerPrefs.GetInt(DataContain.easyScore);
    }

    public static void ArrangeNormalScore(int normalScore)
    {
        PlayerPrefs.SetInt(DataContain.normalScore, normalScore);
    }
    public static int ReadValueNormalScore()
    {
        return PlayerPrefs.GetInt(DataContain.normalScore);
    }

    public static void ArrangeHardScore(int hardScore)
    {
        PlayerPrefs.SetInt(DataContain.hardScore, hardScore);
    }
    public static int ReadValueHardScore()
    {
        return PlayerPrefs.GetInt(DataContain.hardScore);
    }


    //altin icin
    public static void ArrangeEasyGold(int easyGold)
    {
        PlayerPrefs.SetInt(DataContain.easyGold, easyGold);
    }
    public static int ReadValueEasyGold()
    {
        return PlayerPrefs.GetInt(DataContain.easyGold);
    }

    public static void ArrangeNormalGold(int normalGold)
    {
        PlayerPrefs.SetInt(DataContain.normalGold, normalGold);
    }
    public static int ReadValueNormalGold()
    {
        return PlayerPrefs.GetInt(DataContain.normalGold);
    }

    public static void ArrangeHardGold(int hardGold)
    {
        PlayerPrefs.SetInt(DataContain.hardGold, hardGold);
    }
    public static int ReadValueHardGold()
    {
        return PlayerPrefs.GetInt(DataContain.hardGold);
    }


    //muzik icin
    public static void ArrangeMusic(int Music)
    {
        PlayerPrefs.SetInt(DataContain.music, Music);
    }
    public static int ReadValueMusic()
    {
        return PlayerPrefs.GetInt(DataContain.music);

    }

    public static bool IsMusicOpen()
    {
        if(PlayerPrefs.HasKey(DataContain.music))
        {
            return true;
        }
        else
        {
            return false;
        }

    }

}
