using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    
    public GameObject player;
    private Transform playerPos;
    private Vector2 currentPos;
    public float distance;
    public float enemySpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        playerPos = player.GetComponent<Transform>();
        currentPos = GetComponent<Transform>().position;


    }

    // Update is called once per frame
    void Update()
    {
      

        if(Vector2.Distance(transform.position, playerPos.position) < distance)
        {
            transform.position = Vector2.MoveTowards(transform.position, playerPos.position, enemySpeed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, currentPos, enemySpeed * Time.deltaTime);
        }

        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == ("Player"))
        {
            Debug.Log("PlayerHit!");
            //Destroy(collision.gameObject);
        }
    }

}
