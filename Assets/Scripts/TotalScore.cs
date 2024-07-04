using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalScore : MonoBehaviour
{
    public bool ishighScore;

    public bool isdiffScore;

    float highscore;
    Text uiText;
    // Start is called before the first frame update
    void Start()
    {
        if(!GameManager.Gamestart){
            return;
        }

        uiText = GetComponent<Text>();

        uiText.text = "점수: " + GameManager.score.ToString("F0") + " M";

        if (ishighScore) {
            highscore = PlayerPrefs.GetFloat("Score");
            uiText.text = "최고기록: " + highscore.ToString("F0") + " M";
        }
           if (isdiffScore) {
            highscore = PlayerPrefs.GetFloat("Score");
            uiText.text = "남은 거리: " + (highscore - GameManager.score).ToString("F0") + " M";
            if((highscore - GameManager.score) <= 0) {
                uiText.text = "남은거리: 최고기록 달성";
            }
        }
    }
}