using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Paddle grass;
    Vector2 offset;
    Rigidbody2D rb;
    bool onThePaddle = true;
    [SerializeField] AudioClip[] dzwieki = new AudioClip[2];
    [SerializeField] float randomnes = 4.5f;
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - grass.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Launch();
        if (onThePaddle == true)
        {
            BallToPaddle();
        }
        GetComponent<Rigidbody2D>().velocity = speed * (GetComponent<Rigidbody2D>().velocity.normalized);
    }

     void BallToPaddle()
    {
        Vector2 placeGrass = new Vector2(grass.transform.position.x, grass.transform.position.y);
        transform.position = placeGrass + offset;
    }
     void Launch()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // rb.velocity = new Vector2(2f, 15f); lub
            GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 15f);
            onThePaddle = false;
        }
    }
     void OnCollisionEnter2D(Collision2D collision)
    {
        float x = Random.Range(-2.5f, randomnes);
        float y = Random.Range(0f, randomnes);
        Vector2 velocityTweak = new Vector2(x, y);


        if(collision.collider.tag != "blok")
        {
            AudioClip clip = dzwieki[Random.RandomRange(0, dzwieki.Length)];
            GetComponent<AudioSource>().PlayOneShot(clip);
            
            if(collision.collider.tag == "gora")
            {
                float xa = Random.RandomRange(-4.5f, randomnes);
                float ya = Random.Range(0, -4.5f);
                Vector2 a = new Vector2(xa, ya);
                GetComponent<Rigidbody2D>().velocity += a;
            }else if(collision.collider.tag == "prawy")
            {
                float xb = Random.Range(0, -4.5f);
                float yb = Random.Range(randomnes, -4.5f);
                Vector2 b = new Vector2(xb, yb);
                GetComponent<Rigidbody2D>().velocity += b;
            }else if (collision.collider.tag == "lewy")
            {
                float xc = Random.Range(0, randomnes);
                float yc = Random.Range(randomnes, -4.5f);
                Vector2 c = new Vector2(xc, yc);
                GetComponent<Rigidbody2D>().velocity += c;
            }
        }      
        
    }
}
