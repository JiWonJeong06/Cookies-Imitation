using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{   

    const float ORIGIN_SPEED = 2;

    public static float globalSpeed; 

    public static float score;

    public static bool Gamestart;




    // Start is called before the first frame update
    void Awake()
    {
        Gamestart = true;

        if (!PlayerPrefs.HasKey("Score")) {
            PlayerPrefs.SetFloat("Score", 0);
        }
    }

    // Update is called once per frame
    void Update()
    {   //score ++
        if (Gamestart) {
            score += Time.deltaTime * 10f;
            globalSpeed = ORIGIN_SPEED + score * 0.0001f;
        }
    }

    public void GameOver() {
        LoadingSceneManager.LoadScene("TotalScene");
        Gamestart = false;
        float highscore = PlayerPrefs.GetFloat("Score");
        PlayerPrefs.SetFloat("Score", Mathf.Max(highscore, score));
    }
    public void Restart() {
        LoadingSceneManager.LoadScene("InGame");
        score = 0;
        Gamestart = true;
    }


    }
 

