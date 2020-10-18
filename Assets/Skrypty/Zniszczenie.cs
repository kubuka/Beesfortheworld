using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zniszczenie : MonoBehaviour
{
    int count=0;
    public Sprite zniszczenie1;
    public Sprite zniszczenie2;
    public AudioClip niszczenie;
    public GameObject pszczola;
    public GameObject camera;
    public Zmianasceny lvl;
    public level lvl2;
    public RandomSpawn lvl3;
    public GameObject particle;
    bool hasended = false;
    bool isblock = false;

    private void Awake()
    {
       
        if (tag == "onehit")
        {
            isblock = true;
        }else if(tag == "twohit")
        {
            isblock = true;
        }else if (tag == "zerohit")
        {
            isblock = true;
        }
        lvl2 = FindObjectOfType<level>();
        lvl = FindObjectOfType<Zmianasceny>();
        lvl3 = FindObjectOfType<RandomSpawn>();
        if (isblock == true)
        {
            
            lvl.CountBreakableBlocks();
            lvl3.CountBreakableBlocks();
        }
    }

    private void Start()
    {               
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {       
            if(collision.gameObject.name=="pszczola")
        {
            count++;
        }     
    }
    private void Update()
    {
        if (isblock == true)
        {

            if (count == 1)
            {
                if(tag == "onehit")
                {
                    GetComponent<SpriteRenderer>().sprite = zniszczenie2;
                }
                else if(tag == "zerohit")
                {
                    pszczola.GetComponent<AudioSource>().enabled = false;
                    AudioSource.PlayClipAtPoint(niszczenie, new Vector3(camera.transform.position.x, camera.transform.position.y, camera.transform.position.z), 9f);
                    pszczola.GetComponent<AudioSource>().enabled = true;
                    SparcleEffect();
                    lvl.DecrementBrakableBlocks();
                    lvl3.DecrementBrakableBlocks();

                    lvl2.Score();
                    Destroy(gameObject);
                }else
                {
                    GetComponent<SpriteRenderer>().sprite = zniszczenie1;
                }
                
            }
            //
            else if (count == 2)
            {
                if(tag == "onehit")
                {
                    pszczola.GetComponent<AudioSource>().enabled = false;
                    AudioSource.PlayClipAtPoint(niszczenie, new Vector3(camera.transform.position.x, camera.transform.position.y, camera.transform.position.z), 9f);
                    pszczola.GetComponent<AudioSource>().enabled = true;
                    SparcleEffect();
                    lvl.DecrementBrakableBlocks();
                    lvl3.DecrementBrakableBlocks();
                    lvl2.Score();
                    Destroy(gameObject);
                }
                else
                {
                    GetComponent<SpriteRenderer>().sprite = zniszczenie2;
                }
                
            }
            //
            if (count == 3)
            {
                pszczola.GetComponent<AudioSource>().enabled = false;
                AudioSource.PlayClipAtPoint(niszczenie, new Vector3(camera.transform.position.x, camera.transform.position.y, camera.transform.position.z), 9f);
                pszczola.GetComponent<AudioSource>().enabled = true;
                SparcleEffect();
                lvl.DecrementBrakableBlocks();
                lvl3.DecrementBrakableBlocks();
                lvl2.Score();
                Destroy(gameObject);
            }
        }
    }
    void SparcleEffect()
    {
       GameObject gwiazdy = Instantiate(particle, transform.position, transform.rotation);
        Destroy(gwiazdy, 3f);
    }
}
