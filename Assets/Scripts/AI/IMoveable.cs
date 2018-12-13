using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMoveable <T> {
    IEnumerator MoveToCoroutine(T targetPosition);
}
