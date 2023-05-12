using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class EnemyHealth : MonoBehaviour
{
    public TMP_Text scoreCount;
    public int currentHealth ;
    public int score;

    private void Start()
    {
        score = 0;
        currentHealth = 20;
    }
    public void TakeDamage(int damage)
    {
        currentHealth = currentHealth - damage;

        if(currentHealth <= 0)
        {
            int.TryParse(scoreCount.text, out score);
            score += 1;
            scoreCount.SetText(score.ToString());
            if(score >= 7)
            {
                SceneManager.LoadScene(0);
            }
            
            Debug.Log("Dead: " + currentHealth);
            Die();
        }
    }

    

    void Die()
    {
        Destroy(gameObject);
    }
}
