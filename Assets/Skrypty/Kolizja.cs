using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kolizja : MonoBehaviour
{
    float jeden = 0f;
    float dwa = 15f;
    float trzy = -2f;
    float cztery = 5.5f;
    Rigidbody2D rb;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(0f, -0.1f));

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {        

        if (collision.gameObject.tag == "onehit")
        {
            float with = Random.Range(jeden, dwa);
            float height = Random.Range(trzy, cztery);
            gameObject.transform.position = new Vector2(with, height);
            
        }
       if (collision.gameObject.tag == "twohit")
        {
            float with = Random.Range(jeden, dwa);
            float height = Random.Range(trzy, cztery);
            gameObject.transform.position = new Vector2(with, height);
           
        }
       if (collision.gameObject.tag == "zerohit")
        {
            float with = Random.Range(jeden, dwa);
            float height = Random.Range(trzy, cztery);
            gameObject.transform.position = new Vector2(with, height);
           

        }
        
    }
}
