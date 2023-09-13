using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorLock : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}
