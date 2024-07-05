using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScene : MonoBehaviour
{
    // Update is called once per frame
    public void MainSceneUpdate()
    {       
            LoadingSceneManager.LoadScene("Menu");
            GameManager.score = 0;
   
    }
}
