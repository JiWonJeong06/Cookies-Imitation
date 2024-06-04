using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infinity : MonoBehaviour
{
    void LateUpdate() {
        if (transform.position.x > -20) {
            return;
        }
       transform.Translate(70,0,0, Space.Self); 
        
    }
}
