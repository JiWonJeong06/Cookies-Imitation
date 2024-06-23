using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    // Update is called once per frame
    public void SceneChange()
    {
        
            SceneManager.LoadScene("InGame");
   
    }
}
