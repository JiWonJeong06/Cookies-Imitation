using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infinity : MonoBehaviour
{
    void LateUpdate() {
        if (transform.position.x > -29) {
            return;
        }
       transform.Translate(80,0,0, Space.Self); 
        
    }
}
