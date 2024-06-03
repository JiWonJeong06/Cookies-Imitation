using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{   
    const float ORIGIN_SPEED = 2;
    public static float globalSpeed; 
    public static float score;
    public static bool Gamestart;
    public GameObject uiOver;


    // Start is called before the first frame update
    void Start()
    {
        Gamestart = true;
    }

    // Update is called once per frame
    void Update()
    {   //score ++
        if (Gamestart) {
            score += Time.deltaTime * 1.5f;
            globalSpeed = ORIGIN_SPEED + score * 0.01f;
        }
        print((int)score);
    }
    public void GameOver() {
        //uiOver.SetActive(true);
        Gamestart = false;
    }



}
