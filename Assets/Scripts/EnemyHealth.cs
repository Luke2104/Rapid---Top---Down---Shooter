using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    
    public int currentHealth = 20;
    public static bool isEnemyDead = false;

    public void TakeDamage(int damage)
    {
        currentHealth = currentHealth - damage;

        if(currentHealth <= 0 && isEnemyDead == false)
        {
            Debug.Log("Dead: " + currentHealth);
            isEnemyDead = true;
            Destroy(gameObject);
        }
    }
}
