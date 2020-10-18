using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autoplay : MonoBehaviour
{
    float ballPos;
    int screenUnits = 16;
    [SerializeField] GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
       
        Vector2 ballpos = new Vector2(ball.transform.position.x,ball.transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {        
        Vector2 paddlePos = new Vector2(ball.transform.position.x, transform.position.y);      
        transform.position = paddlePos;
    }
}
