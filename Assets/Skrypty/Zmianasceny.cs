using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zmianasceny : MonoBehaviour
{
    int blokimax;
     float toEnter = 0.4f;
    float timeElapsed;
    public bool zmieniona = false;


    public void Update()
    {
        if (blokimax == 0)
        {
            timeElapsed += Time.deltaTime;
            if (timeElapsed > toEnter)
            {
                zmieniona = true;
                Scenakoncowa();
            }
        }
        
    }

    public void CountBreakableBlocks()
    {
        blokimax++;
    }
    public void DecrementBrakableBlocks()
    {
        blokimax--;
    }

    void Scenakoncowa()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
