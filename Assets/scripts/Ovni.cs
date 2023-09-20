using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ovni : MonoBehaviour
{
    private MovementBehavior mvb;
    public GameObject bulletOvni;
    public GameObject player;
    private float timer;
    public float limit;
    Vector3 dir;

    private bool active;

    private void Start()
    {
        timer = 0f;
        active = true;
        mvb = GetComponent<MovementBehavior>();
    }

    public void SetDirection(Vector3 d)
    {
        dir = d;
        dir.Normalize();
    }
    // Update is called once per frame
    void Update()
    {
        mvb.Move(dir);
        
        
        if (active)
        {
            Vector3 dir;
            timer = timer + Time.deltaTime;
            if (timer > limit)
            {
                /*GameObject spawner = Instantiate(bulletOvni, transform.position, Quaternion.identity);
                if (player != null)
                    dir = player.transform.position - spawner.transform.position;
                else
                {
                    dir = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), 0);
                }
                spawner.GetComponent<Bullet>().SetDirection(dir);
                timer = 0f;
                GetComponent<ShootingBehavior>().Shoot2();*/
                GameObject spawner = Instantiate(bulletOvni, transform.position, Quaternion.identity);
                if (player != null)
                    dir = player.transform.position - spawner.transform.position;
                else
                    dir = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), 0);
                spawner.GetComponent<Bullet>().SetDirection(dir);
                timer = 0f;

            }
            
        }
    }

    public void StopSpawner()
    {
        active = false;
    }

    public void StartSpawner()
    {
        active = true;
    }
}
