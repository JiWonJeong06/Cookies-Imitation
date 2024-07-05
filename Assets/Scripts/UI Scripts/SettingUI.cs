using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingUI : MonoBehaviour
{

    public GameObject uiPanel; // 활성화/비활성화할 UI 패널

    public void TogglePanel()
    {
        if (uiPanel != null) {
            uiPanel.SetActive(!uiPanel.activeSelf);
        }
    }
    public void DeactivatePanel()
    {
        if (uiPanel != null)
        {
            uiPanel.SetActive(false);
        }
    }
    
}
