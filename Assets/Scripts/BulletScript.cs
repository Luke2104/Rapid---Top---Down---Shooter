using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public int damage = 5;
    
    
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Enemy"))
        {
            Debug.Log("Hit");
            collision.gameObject.GetComponent<EnemyHealth>().TakeDamage(damage);
        }
    }
}
