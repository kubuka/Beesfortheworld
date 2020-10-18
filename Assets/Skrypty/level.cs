using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class level : MonoBehaviour
{
    [SerializeField] int blokimax;
    [SerializeField] int blokimin;
    [SerializeField] int roznica;
    public int zniszczone = 0;
    public Text score;
    public Text haj;
    public int highScore;

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("highscore", 0);
        haj.text = "HighScore: "+ highScore.ToString();
    }

    private void Update()
    {
        
        
        if (zniszczone > highScore)
        {
            PlayerPrefs.SetInt("highscore", zniszczone);
            score.text = zniszczone.ToString();
            
        }
        else
        {
            score.text = zniszczone.ToString();
        }      
        
    }

    public void Score()
    {
        zniszczone += 23;
    }
    public void CountBreakableBlocks()
    {
        blokimax++;
    }
    public void DecrementBrakableBlocks()
    {
        blokimax--;
    }
}    
    
