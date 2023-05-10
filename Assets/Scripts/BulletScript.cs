using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private float hits;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        { 
            Destroy(gameObject);
            hits += 1;

            if (hits >= 5)
            {
                Debug.Log(hits);
                Destroy(collision.gameObject);
                hits = 0;
            }

        }
       
    }
}
