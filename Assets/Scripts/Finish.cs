using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{

    public static bool isPaused;

    public GameObject EndScreen;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            EndScreen.SetActive(true);

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            isPaused = true;
        }

    }
}
