using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;

    [SerializeField]
    private float bulletSpeed;

    private bool autoFire;

    

    // Update is called once per frame
    void Update()
    {

        if (autoFire)
        {
            Debug.Log("Firing!");
            FireBullet();
        }
    }

    private void FireBullet()
    {
     
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        rb.velocity = bulletSpeed * transform.up;
    }

    private void OnFire(InputValue inputValue)
    {
        autoFire = inputValue.isPressed;
    }
}
