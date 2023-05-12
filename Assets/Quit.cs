using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Quit : MonoBehaviour
{


    // Update is called once per frame
    public void OnPlayerInputExit(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Application.Quit();
        }


    }
}
