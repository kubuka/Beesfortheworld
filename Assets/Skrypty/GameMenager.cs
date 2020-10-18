using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameMenager : MonoBehaviour
{
	private void Start()
	{
		Cursor.visible = true;
	}


	public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void FistScene()
    {
        SceneManager.LoadScene(0);
    }
    public void Esc()
    {
        Application.Quit();
        Debug.Log("wyjscie");
    }
    public void Retry()
    {
        SceneManager.LoadScene(1);
    }
}

