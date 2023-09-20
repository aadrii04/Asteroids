using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBehavior : MonoBehaviour
{
    public GameObject ExplosionPre;
    public void DestroyObject()
    {
        if (ExplosionPre != null)
        {
            Instantiate(ExplosionPre, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }


    public void DisableObject()
    {
        if (ExplosionPre != null)
        {
            Instantiate(ExplosionPre, transform.position, Quaternion.identity);
        }
        gameObject.SetActive(false);
    }
}
