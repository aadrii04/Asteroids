using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBehavior : MonoBehaviour
{
    public float damage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //   Debug.Log("Bala colisiona " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<HealthBehavior>().Hurt(damage);
        }
        else
        {
            collision.gameObject.GetComponent<HealthBehavior>().Hurt(damage);
        }
    }
}
