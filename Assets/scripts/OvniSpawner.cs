using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvniSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ovni_2;
    private float timer;
    public float limit;
    public float direction;
    private int numRandom;
    //private float randomNum;

    private bool active;

    void Start()
    {
        timer = 0f;
        active = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (active)
        {
            Vector3 dir;
            
            timer = timer + Time.deltaTime;
            if (timer > limit)
            {
                numRandom = Random.Range(0, 2);
                if (numRandom == 1)
                {
                    dir = new Vector3(direction, 0f, 0f);
                    GameObject ovni = Instantiate(ovni_2, transform.position, Quaternion.identity);

                    ovni.GetComponent<Ovni>().SetDirection(dir);
                    timer = 0f;
                }
                else if(numRandom == 0)
                {
                    dir = new Vector3(-direction, 0f, 0f);
                    GameObject ovni = Instantiate(ovni_2, transform.position, Quaternion.identity);

                    ovni.GetComponent<Ovni>().SetDirection(dir);
                    timer = 0f;
                }

            }
        }
    }

    public void StopSpawner()
    {
        active = false;
    }

    public void TrueSpawner()
    {
        active = true;
    }
}