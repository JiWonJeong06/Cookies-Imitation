using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;


public class NoCursor : MonoBehaviour

{
    public GameObject defaultSelectedButton;
    // Use this for initialization
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        
        
    }
    void Update(){
      if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2) )
        {
            EventSystem.current.SetSelectedGameObject(defaultSelectedButton);
        }
    }
}