using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChecker : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector3 postrans = Camera.main.WorldToViewportPoint(transform.position); // se convierte las cordenadas a la posicion -1,-1 -- 1,1
        if(postrans.x < -1.5f || postrans.x > 1.5f || postrans.y < -1.5f || postrans.y > 1.5f)
        {
            Destroy(gameObject);
        }
    }
}
