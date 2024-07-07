using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideBook : MonoBehaviour
{
    public GameObject uiPanel;
    
    public void TogglePanel()
    {
        if (uiPanel != null)
        {
            uiPanel.SetActive(!uiPanel.activeSelf);
        }
    }
}
