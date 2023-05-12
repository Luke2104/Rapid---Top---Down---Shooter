using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class StartAgain : MonoBehaviour
{

    // Update is called once per frame
    public void OnPlayerInputRestart(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            SceneManager.LoadScene(1);
        }
    }
}
