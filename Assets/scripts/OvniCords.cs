using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvniCords : MonoBehaviour
{
    private MovementBehavior mvb;
    public float speed; 
    public float boundary;
    private int direction = 1; 
    Vector3 dir;


    private void Start()
    {
        mvb = GetComponent<MovementBehavior>();
    }

    public void SetDirection(Vector3 d)
    {
        dir = d;
        dir.Normalize();
    }
 
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coordenada1"))
        {
            direction = -1; 
        }
        else if (other.CompareTag("Coordenada2"))
        {
            direction = 1; 
        }
    }

   
    void Update()
    {
        mvb.Move(dir);
        transform.Translate(Vector3.right * speed * direction * Time.deltaTime);
       
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, -boundary, boundary),
            Mathf.Clamp(transform.position.y, -boundary, boundary),
            Mathf.Clamp(transform.position.z, -boundary, boundary)
        );
    }
}
