using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speedRotation;
    private NewControls nc;
    private MovementBehavior mvb;
    //public GameObject shotPrefab;

    private void OnEnable()
    {
        Vector3 postrans = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.5f));
        postrans.z = 0;
        transform.position = postrans;
    }

    private void Start()
    {
        nc = GetComponent<NewControls>();
        mvb = GetComponent<MovementBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, nc.moveValue.x*speedRotation);
        mvb.Move(nc.moveValue.y * transform.right);
        /*if (Input.GetKey(KeyCode.A))
            transform.Rotate(0, 0, speedRotation);
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(0, 0, -speedRotation);
        if (Input.GetKey(KeyCode.W))
        {
            mvb.Move(transform.right);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        { 
        GameObject bullet = Instantiate(shotPrefab, transform.position, Quaternion.identity);
        bullet.GetComponent<Bullet>().SetDirection(transform.right);
        }*/
            
    }
}
