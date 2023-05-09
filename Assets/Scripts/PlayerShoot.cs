using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerShoot : MonoBehaviour
{
    public float force;
    public GameObject bulletPrefab;
    public GameObject gunEnd;
    private Vector3 aim;

    

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos += Camera.main.transform.forward * 10f;
        aim = Camera.main.ScreenToWorldPoint(mousePos);
        if(Input.GetKey(KeyCode.Mouse0))
        {
            gunEnd.transform.LookAt(aim);
            GameObject bullet = Instantiate(bulletPrefab, gunEnd.transform.position, Quaternion.identity);
            bullet.transform.LookAt(aim);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();

        }
      
        
    }

    
}
