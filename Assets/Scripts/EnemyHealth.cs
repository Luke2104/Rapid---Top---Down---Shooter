using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    
    public int currentHealth ;
    public static bool isEnemyDead = false;

    private void Start()
    {
        currentHealth = 20;
    }
    public void TakeDamage(int damage)
    {
        currentHealth = currentHealth - damage;

        if(currentHealth <= 0 && isEnemyDead == false)
        {
            Debug.Log("Dead: " + currentHealth);
            isEnemyDead = true;
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject, 1f);
    }
}
