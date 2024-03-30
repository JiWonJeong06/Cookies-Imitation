using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ReScroll : MonoBehaviour
{
   void LateUpdate() {
    if (transform.position.x > -10){
        return;
        }
    transform.Translate(20,0,0,Space.Self);
   }
}
