using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public bool ishighScore;

    float highscore;
    Text uiText;
    // Start is called before the first frame update
    void Start()
    {
        if(!GameManager.Gamestart){
            return;
        }

        uiText = GetComponent<Text>();

        if (ishighScore) {
            highscore = PlayerPrefs.GetFloat("Score");
            uiText.text = (highscore - GameManager.score).ToString("F1") + " M";
        }

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(!GameManager.Gamestart){
            return;}
        
        if (ishighScore && GameManager.score < highscore)
            return;
        
        uiText.text = GameManager.score.ToString("F1") + " M";
    }
}
