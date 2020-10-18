using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{   
    float jeden = 0f;
    float dwa = 15f;
    float trzy = -2f;
    float cztery = 5.5f;
     int iloscdospawnuczer =1;
     int iloscdospawnurzu =1;
     int iloscdospawnuniebr =1;
     [SerializeField] int blokimaxi;
    [SerializeField] bool tak = false;
    
    

    Rigidbody2D rb;

    List<Vector2> miejsca;

    public GameObject klocczer;
    public GameObject klocrz;
    public GameObject klocnieb;

    public void FixedUpdate()
    {
        if (blokimaxi == 1)
        {
            iloscdospawnurzu += 8;
            iloscdospawnuniebr += 3;
            iloscdospawnuczer += 2;
            Pojawianie();
        }
        
    }
    public void Start()
    {
        //Pojawianie();
        if (blokimaxi == 0)
        {
            iloscdospawnurzu += 5;
            iloscdospawnuniebr += 2;
            iloscdospawnuczer += 1;
            Pojawianie();
        }

    }

    private void Pojawianie()
    {
        miejsca = new List<Vector2>();
        int[] iloscczer = new int[iloscdospawnuczer];
        int[] iloscrz = new int[iloscdospawnurzu];
        int[] iloscnieb = new int[iloscdospawnuniebr];

        foreach (var item in iloscczer)
        {

            float with = Random.Range(jeden, dwa);
            float height = Random.Range(trzy, cztery);
            GameObject a = Instantiate(klocczer) as GameObject;
            a.transform.position = new Vector2(with, height);
            miejsca.Add(a.transform.position);


        }
        foreach (var item in iloscrz)
        {
            float with = Random.Range(jeden, dwa);
            float height = Random.Range(trzy, cztery);
            GameObject a = Instantiate(klocrz) as GameObject;
            a.transform.position = new Vector2(with, height);
            miejsca.Add(a.transform.position);

        }
        foreach (var item in iloscnieb)
        {
            float with = Random.Range(jeden, dwa);
            float height = Random.Range(trzy, cztery);
            GameObject a = Instantiate(klocnieb) as GameObject;
            a.transform.position = new Vector2(with, height);
            miejsca.Add(a.transform.position);

        }
    }

    public void CountBreakableBlocks()
    {
        blokimaxi++;
    }
    public void DecrementBrakableBlocks()
    {
        blokimaxi--;
    }

}
