using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StartLoadingScene : MonoBehaviour
{

    public void Update()
    { 
        LoadingSceneManager.LoadScene("Menu");
    }
}
