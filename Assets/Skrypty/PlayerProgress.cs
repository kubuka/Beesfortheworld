using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerProgress : MonoBehaviour
{
    level score;
    public static int highscore;
    public Text text;
    public int wynik;

    public void Start()
    {
        score = new level();
        highscore = PlayerPrefs.GetInt("highscore", highscore);
        PlayerPrefs.Save();
    }

    private void Update()
    {
        wynik = score.zniszczone;
        if (wynik > highscore)
        {
            highscore = wynik;            
            highscore = PlayerPrefs.GetInt("highscore", highscore);
            PlayerPrefs.Save();
        }
        text.text = wynik.ToString();
    }
}
