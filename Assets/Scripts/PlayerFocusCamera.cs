using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFocusCamera : MonoBehaviour {
    [SerializeField]
    private Camera focusCamera;

    private Transform target;
    public Transform Target
    {
        get
        {
            return target;
        }

        set
        {
            target = value;
            if(value == null)
            {
                StopCoroutine(currentFocusTargetCoroutine);
            }

            FocusToTransform(value);
        }
    }

    private IEnumerator currentFocusTargetCoroutine;

    public void FocusToTransform(Transform targetTransform)
    {
        if(currentFocusTargetCoroutine != null)
        StopCoroutine(currentFocusTargetCoroutine);

        currentFocusTargetCoroutine = MoveToCoroutine(targetTransform);
        StartCoroutine(currentFocusTargetCoroutine);
    }

    private IEnumerator MoveToCoroutine(Transform targetTransform)
    {
        while (target != null)
        {
            focusCamera.transform.position = new Vector3(targetTransform.position.x, targetTransform.position.y, -1);
            yield return null;
        }
    }
}
