using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionSound : MonoBehaviour
{
    // Start is called before the first frame update
   public void PlaySound()
    {
        GetComponent<AudioSource>().Play();
    }
}
