using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {
    public float GetMouseScroll()
    {
        return -Input.GetAxis("Mouse ScrollWheel");
    }

    public float GetHorizontalInput()
    {
        if (Input.GetAxisRaw("Horizontal") == 0)
        {
            return 0;
        }
        else
        {
            return Input.GetAxisRaw("Horizontal") > 0 ? 1 : -1;
        }
    }

    public float GetVerticalInput()
    {
        if (Input.GetAxisRaw("Vertical") == 0)
        {
            return 0;
        }
        else
        {
            return Input.GetAxisRaw("Vertical") > 0 ? 1 : -1;
        }
    }
}
