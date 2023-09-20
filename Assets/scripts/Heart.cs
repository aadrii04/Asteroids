using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    private MovementBehavior mvb;
    private HealthBehavior healthbehavior;
    Vector3 dir;
    // Start is called before the first frame update
    private void Start()
    {
        mvb = GetComponent<MovementBehavior>();
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        if(playerObject != null)
        {
            healthbehavior = playerObject.GetComponent<HealthBehavior>();
        }
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
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            healthbehavior.Heal(healthbehavior.maxHealth);
            Destroy(gameObject);
        }
    }
}
