using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Movement : MonoBehaviour, IMoveable<Vector3> {
    private IEnumerator currentCoroutineMovement;

    private Vector3 targetPosition;

    public Vector3 target
    {
        get { return targetPosition; }
        set
        {
            targetPosition = value;

            if (currentCoroutineMovement != null)
            StopCoroutine(currentCoroutineMovement);

            currentCoroutineMovement = MoveToCoroutine(targetPosition);
            StartCoroutine(currentCoroutineMovement);
        }
    }

    public IEnumerator MoveToCoroutine(Vector3 targetPosition)
    {
        while(Vector3.Magnitude(transform.position - targetPosition) > 0.05f)
        {
            transform.Translate((targetPosition - transform.position).normalized * Time.deltaTime * 0.1f * TimeSystem.timeSpeed * GetComponent<Characters>().m_Speed);

            yield return null;
        }
    }
}
