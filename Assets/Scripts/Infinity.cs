using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Infinity : MonoBehaviour
{
    public UnityEvent onMove;

    void LateUpdate() {
        if (transform.position.x > -20) {
            return;
        }

       transform.Translate(70,0,0, Space.Self);
       onMove.Invoke();
    }
}
