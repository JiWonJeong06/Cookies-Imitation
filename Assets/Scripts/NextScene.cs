using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        
        LoadingSceneManager.LoadScene("InGame");
   
    }
}
