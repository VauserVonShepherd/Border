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

    public Vector3 GetInputScreenPosition()
    {
        Vector2 ScreenInputPosition = Vector2.zero;
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            ScreenInputPosition = Input.mousePosition;
            return ScreenInputPosition;
        }else if(Input.touchCount > 0)
        {
            ScreenInputPosition = Input.touches[0].position;
            return ScreenInputPosition;
        }

        return ScreenInputPosition;
    }
    
    public bool GetSelectionInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            return true;
        }
        else if (Input.touchCount > 0)
        {
            return true;
        }
        return false;
    }

    //public bool GetMoveInput()
    //{
    //    if (Input.GetMouseButtonDown(1))
    //    {
    //        return true;
    //    }
    //    else if (Input.touchCount == 1)
    //    {
    //        return true;
    //    }
    //    return false;
    //}
}
