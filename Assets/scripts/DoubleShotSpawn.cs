using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleShotSpawn : MonoBehaviour
{
    public GameObject DoubleShot;
    public GameObject player;
    private float timer;
    public float limit;

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

            Vector3 dir; /// todo va al ovni
            timer = timer + Time.deltaTime;
            if (timer > limit)
            {
                GameObject spawner = Instantiate(DoubleShot, transform.position, Quaternion.identity);
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

    public void TrueSpawner()
    {
        active = true;
    }
}
