using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SingletoneSpawn : MonoBehaviour
{
    private void Awake()
    {
        int levelStatusCount = FindObjectsOfType<SingletoneSpawn>().Length;


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
