using UnityEngine;
using System.Collections;

public class NoCursor : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}