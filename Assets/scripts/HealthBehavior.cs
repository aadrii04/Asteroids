using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; // para poder usar unityevents

public class HealthBehavior : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;

    public UnityEvent OnDie; // declaracion del evento
    public UnityEvent<float> OnChangeHealth;

    private void OnEnable()
    {
        currentHealth = maxHealth;
        OnChangeHealth.Invoke(currentHealth);
    }

    public void Heal(float health)
    {
       currentHealth += health;
        if(currentHealth > maxHealth) // para que la vida que tiene el player no supere a la maxima.
        {
            currentHealth = maxHealth;
        }
        OnChangeHealth.Invoke(currentHealth);
    }

    public void Hurt(float damage)
    {
        currentHealth -= damage;
        if(currentHealth <= 0)
        {
            OnDie.Invoke(); //avisa en este caso que la vida a bajado
            currentHealth = 0;
        }
        OnChangeHealth.Invoke(currentHealth);
    }

    public float GetHealth()
    {
        return currentHealth;
    }


}
