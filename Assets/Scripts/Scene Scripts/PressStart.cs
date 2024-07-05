using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class PressStart : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown) {
            LoadingSceneManager.LoadScene("Menu");
        }
    }
}
