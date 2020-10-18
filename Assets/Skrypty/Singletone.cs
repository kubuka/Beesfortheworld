using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Singletone : MonoBehaviour
{
    private void Awake()
    {
        int levelStatusCount = FindObjectsOfType<Singletone>().Length;
        
        
        if (levelStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "End")
        {
            Destroy(gameObject);
        }
    }
}
