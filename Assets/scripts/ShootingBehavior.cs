using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBehavior : MonoBehaviour
{
    public GameObject shotPrefab;
    private bool doubleshot;
    public float timeDoubleShot;
    //public GameObject player;
    

    public void Shoot()
    {
        if(!doubleshot)
        {
            GameObject bullet = Instantiate(shotPrefab, transform.position, Quaternion.identity);
            bullet.GetComponent<Bullet>().SetDirection(transform.right);
        }
        else
        {
            GameObject bullet1 = Instantiate(shotPrefab, transform.position + new Vector3(0.1f, 0f, 0f), Quaternion.identity);
            bullet1.GetComponent<Bullet>().SetDirection(transform.right);
            GameObject bullet2 = Instantiate(shotPrefab, transform.position + new Vector3(0.9f, 0f, 0f), Quaternion.identity);
            bullet2.GetComponent<Bullet>().SetDirection(transform.right);
        }
        
    }  
    public void DoubleShot()
    {
        doubleshot = true;
        Invoke("StopDoubleShot", timeDoubleShot);
    }
    private void StopDoubleShot()
    {
        doubleshot = false;
    }
}
